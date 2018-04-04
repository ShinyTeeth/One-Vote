using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace onevote.Migrations
{
    public partial class ballotElectionId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EID",
                table: "Ballots",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EID",
                table: "Ballots");
        }
    }
}
