using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Darkbet.Infra.Data.Migrations
{
    public partial class adicionandodata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "wheelOfFortunes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "wheelOfFortunes");
        }
    }
}
