﻿// <auto-generated />
using FinalPrepSqlite.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FinalPrepSqlite.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220416211913_m1")]
    partial class m1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.4");

            modelBuilder.Entity("FinalPrepSqlite.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("School")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("StudentId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            FirstName = "Jane",
                            LastName = "Smith",
                            School = "Medicine"
                        },
                        new
                        {
                            StudentId = 2,
                            FirstName = "John",
                            LastName = "Fisher",
                            School = "Engineering"
                        },
                        new
                        {
                            StudentId = 3,
                            FirstName = "Pamela",
                            LastName = "Baker",
                            School = "Food Science"
                        },
                        new
                        {
                            StudentId = 4,
                            FirstName = "Peter",
                            LastName = "Taylor",
                            School = "Mining"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
