using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VitoriaMariaStudio.Repository.Migrations
{
    public partial class AdicionandoPropriedadeExpectedTimeInJobEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<TimeSpan>(
                name: "ExpectedTime",
                table: "Jobs",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpectedTime",
                table: "Jobs");
        }
    }
}
