using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace onevote.Migrations
{
    public partial class fullnames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FullNameA",
                table: "Elections",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FullNameB",
                table: "Elections",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullNameA",
                table: "Elections");

            migrationBuilder.DropColumn(
                name: "FullNameB",
                table: "Elections");
        }
    }
}
