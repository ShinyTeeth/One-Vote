﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using onevote.Models;
using System;

namespace onevote.Migrations
{
    [DbContext(typeof(OnevoteContext))]
    [Migration("20180403034606_fullnames")]
    partial class fullnames
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011");

            modelBuilder.Entity("onevote.Models.Ballot", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateSubmitted");

                    b.Property<int?>("ElectionID");

                    b.Property<bool>("VotedA");

                    b.Property<bool>("VotedB");

                    b.HasKey("ID");

                    b.HasIndex("ElectionID");

                    b.ToTable("Ballots");
                });

            modelBuilder.Entity("onevote.Models.Candidate", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("FirstName");

                    b.Property<string>("FullName");

                    b.Property<string>("LastName");

                    b.HasKey("ID");

                    b.ToTable("Candidates");
                });

            modelBuilder.Entity("onevote.Models.Election", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CandidateAID");

                    b.Property<int?>("CandidateBID");

                    b.Property<DateTime>("EndDateTime");

                    b.Property<string>("FullNameA");

                    b.Property<string>("FullNameB");

                    b.Property<string>("Location");

                    b.Property<DateTime>("StartDateTime");

                    b.HasKey("ID");

                    b.HasIndex("CandidateAID");

                    b.HasIndex("CandidateBID");

                    b.ToTable("Elections");
                });

            modelBuilder.Entity("onevote.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("onevote.Models.Ballot", b =>
                {
                    b.HasOne("onevote.Models.Election", "Election")
                        .WithMany()
                        .HasForeignKey("ElectionID");
                });

            modelBuilder.Entity("onevote.Models.Election", b =>
                {
                    b.HasOne("onevote.Models.Candidate", "CandidateA")
                        .WithMany()
                        .HasForeignKey("CandidateAID");

                    b.HasOne("onevote.Models.Candidate", "CandidateB")
                        .WithMany()
                        .HasForeignKey("CandidateBID");
                });
#pragma warning restore 612, 618
        }
    }
}