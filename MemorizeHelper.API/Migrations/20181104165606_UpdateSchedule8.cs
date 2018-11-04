﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace MemorizeHelper.API.Migrations
{
    public partial class UpdateSchedule8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StringContent",
                table: "MemorizeUnits",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UnitContentId",
                table: "MemorizeUnits",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Content",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Content", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MemorizeUnits_UnitContentId",
                table: "MemorizeUnits",
                column: "UnitContentId");

            migrationBuilder.AddForeignKey(
                name: "FK_MemorizeUnits_Content_UnitContentId",
                table: "MemorizeUnits",
                column: "UnitContentId",
                principalTable: "Content",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MemorizeUnits_Content_UnitContentId",
                table: "MemorizeUnits");

            migrationBuilder.DropTable(
                name: "Content");

            migrationBuilder.DropIndex(
                name: "IX_MemorizeUnits_UnitContentId",
                table: "MemorizeUnits");

            migrationBuilder.DropColumn(
                name: "StringContent",
                table: "MemorizeUnits");

            migrationBuilder.DropColumn(
                name: "UnitContentId",
                table: "MemorizeUnits");
        }
    }
}
