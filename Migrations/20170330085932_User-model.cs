using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Motochamp.Migrations
{
    public partial class Usermodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "Bikes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Registration",
                table: "Bikes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Bikes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Year",
                table: "Bikes",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bikes_UserId",
                table: "Bikes",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bikes_Users_UserId",
                table: "Bikes",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bikes_Users_UserId",
                table: "Bikes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Bikes_UserId",
                table: "Bikes");

            migrationBuilder.DropColumn(
                name: "Brand",
                table: "Bikes");

            migrationBuilder.DropColumn(
                name: "Registration",
                table: "Bikes");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Bikes");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "Bikes");
        }
    }
}
