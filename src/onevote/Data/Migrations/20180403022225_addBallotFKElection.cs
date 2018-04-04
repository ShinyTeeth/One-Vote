using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace onevote.Migrations
{
    public partial class addBallotFKElection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ElectionID",
                table: "Ballots",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Ballots_ElectionID",
                table: "Ballots",
                column: "ElectionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Ballots_Elections_ElectionID",
                table: "Ballots",
                column: "ElectionID",
                principalTable: "Elections",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ballots_Elections_ElectionID",
                table: "Ballots");

            migrationBuilder.DropIndex(
                name: "IX_Ballots_ElectionID",
                table: "Ballots");

            migrationBuilder.AlterColumn<int>(
                name: "ElectionID",
                table: "Ballots",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
