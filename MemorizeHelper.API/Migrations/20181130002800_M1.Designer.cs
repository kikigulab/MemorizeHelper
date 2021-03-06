﻿// <auto-generated />
using System;
using MemorizeHelper.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MemorizeHelper.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20181130002800_M1")]
    partial class M1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-preview2-35157");

            modelBuilder.Entity("MemorizeHelper.API.Models.MemorizeUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDate");

                    b.Property<bool>("IsPrivate");

                    b.Property<string>("OwnerUsername");

                    b.Property<string>("Priority");

                    b.Property<string>("StringContent");

                    b.Property<string>("SubjectName");

                    b.Property<string>("Tags");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("MemorizeUnits");
                });

            modelBuilder.Entity("MemorizeHelper.API.Models.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<int?>("UnitId");

                    b.HasKey("Id");

                    b.HasIndex("UnitId");

                    b.ToTable("Schedule");
                });

            modelBuilder.Entity("MemorizeHelper.API.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MemorizeHelper.API.Models.Value", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Values");
                });

            modelBuilder.Entity("MemorizeHelper.API.Models.Schedule", b =>
                {
                    b.HasOne("MemorizeHelper.API.Models.MemorizeUnit", "Unit")
                        .WithMany("Schedules")
                        .HasForeignKey("UnitId");
                });
#pragma warning restore 612, 618
        }
    }
}
