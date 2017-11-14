using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using FoxManager.Entities;

namespace FoxManager.Migrations
{
    [DbContext(typeof(FoxManagerContext))]
    partial class FoxManagerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "1.1.3");

            modelBuilder.Entity("FoxManager.Models.Division", b =>
                {
                    b.Property<int>("DivisionId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClassName");

                    b.Property<string>("Technology");

                    b.HasKey("DivisionId");

                    b.ToTable("Divisions");
                });

            modelBuilder.Entity("FoxManager.Models.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DescriptionOfTask");

                    b.Property<DateTime>("DueDate");

                    b.Property<int>("PriorityLevel");

                    b.Property<int?>("StudentId")
                        .IsRequired();

                    b.HasKey("ProjectId");

                    b.HasIndex("StudentId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("FoxManager.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("StudentName");

                    b.Property<int?>("TeamId");

                    b.HasKey("StudentId");

                    b.HasIndex("TeamId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("FoxManager.Models.Team", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("DivisionId");

                    b.Property<string>("TeamName");

                    b.HasKey("TeamId");

                    b.HasIndex("DivisionId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("FoxManager.Models.Project", b =>
                {
                    b.HasOne("FoxManager.Models.Student", "Student")
                        .WithMany("Projects")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FoxManager.Models.Student", b =>
                {
                    b.HasOne("FoxManager.Models.Team", "Team")
                        .WithMany("Students")
                        .HasForeignKey("TeamId");
                });

            modelBuilder.Entity("FoxManager.Models.Team", b =>
                {
                    b.HasOne("FoxManager.Models.Division")
                        .WithMany("Teams")
                        .HasForeignKey("DivisionId");
                });
        }
    }
}
