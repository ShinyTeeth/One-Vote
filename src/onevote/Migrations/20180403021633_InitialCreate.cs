using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace onevote.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ballots",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    DateSubmitted = table.Column<DateTime>(nullable: false),
                    ElectionID = table.Column<int>(nullable: false),
                    VotedA = table.Column<bool>(nullable: false),
                    VotedB = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ballots", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Candidates",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidates", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Elections",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CandidateAID = table.Column<int>(nullable: true),
                    CandidateBID = table.Column<int>(nullable: true),
                    EndDateTime = table.Column<DateTime>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    StartDateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Elections", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Elections_Candidates_CandidateAID",
                        column: x => x.CandidateAID,
                        principalTable: "Candidates",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Elections_Candidates_CandidateBID",
                        column: x => x.CandidateBID,
                        principalTable: "Candidates",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Elections_CandidateAID",
                table: "Elections",
                column: "CandidateAID");

            migrationBuilder.CreateIndex(
                name: "IX_Elections_CandidateBID",
                table: "Elections",
                column: "CandidateBID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ballots");

            migrationBuilder.DropTable(
                name: "Elections");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Candidates");
        }
    }
}
