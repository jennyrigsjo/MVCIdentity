﻿// <auto-generated />
using MVCBasics.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVCBasics.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20220829124930_Insert dummy data")]
    partial class InsertDummyData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MVCBasics.Models.Person", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            City = "New Asgard",
                            Name = "Thor Odinson",
                            Phone = "0123 456789"
                        },
                        new
                        {
                            ID = 2,
                            City = "Valhalla",
                            Name = "Loki Odinson",
                            Phone = "1234 567890"
                        },
                        new
                        {
                            ID = 3,
                            City = "New York",
                            Name = "Jane Foster",
                            Phone = "2345 678901"
                        },
                        new
                        {
                            ID = 4,
                            City = "New York",
                            Name = "Darcy Lewis",
                            Phone = "3456 789012"
                        },
                        new
                        {
                            ID = 5,
                            City = "Stockholm",
                            Name = "Erik Selvig",
                            Phone = "4567 890123"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
