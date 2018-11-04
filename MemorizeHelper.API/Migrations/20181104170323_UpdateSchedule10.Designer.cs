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
    [Migration("20181104170323_UpdateSchedule10")]
    partial class UpdateSchedule10
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-preview2-35157");

            modelBuilder.Entity("MemorizeHelper.API.Models.Content", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.ToTable("Content");
                });

            modelBuilder.Entity("MemorizeHelper.API.Models.MemorizeUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDate");

                    b.Property<bool>("IsPrivate");

                    b.Property<int?>("OwnerUserid");

                    b.Property<string>("Priority");

                    b.Property<string>("StringContent");

                    b.Property<string>("SubjectName");

                    b.Property<string>("Tags");

                    b.Property<string>("Title");

                    b.Property<int?>("UnitContentId");

                    b.HasKey("Id");

                    b.HasIndex("OwnerUserid");

                    b.HasIndex("UnitContentId");

                    b.ToTable("MemorizeUnits");
                });

            modelBuilder.Entity("MemorizeHelper.API.Models.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<int?>("MemorizeUnitId");

                    b.HasKey("Id");

                    b.HasIndex("MemorizeUnitId");

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

            modelBuilder.Entity("MemorizeHelper.API.Models.User_", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("MemorizeUnitId");

                    b.Property<string>("Username");

                    b.HasKey("id");

                    b.HasIndex("MemorizeUnitId");

                    b.ToTable("User_");
                });

            modelBuilder.Entity("MemorizeHelper.API.Models.Value", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Values");
                });

            modelBuilder.Entity("MemorizeHelper.API.Models.MemorizeUnit", b =>
                {
                    b.HasOne("MemorizeHelper.API.Models.User_", "OwnerUser")
                        .WithMany()
                        .HasForeignKey("OwnerUserid");

                    b.HasOne("MemorizeHelper.API.Models.Content", "UnitContent")
                        .WithMany()
                        .HasForeignKey("UnitContentId");
                });

            modelBuilder.Entity("MemorizeHelper.API.Models.Schedule", b =>
                {
                    b.HasOne("MemorizeHelper.API.Models.MemorizeUnit")
                        .WithMany("Schedules")
                        .HasForeignKey("MemorizeUnitId");
                });

            modelBuilder.Entity("MemorizeHelper.API.Models.User_", b =>
                {
                    b.HasOne("MemorizeHelper.API.Models.MemorizeUnit")
                        .WithMany("SubscribedUsers")
                        .HasForeignKey("MemorizeUnitId");
                });
#pragma warning restore 612, 618
        }
    }
}
