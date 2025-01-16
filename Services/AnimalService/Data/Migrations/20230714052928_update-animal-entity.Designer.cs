﻿// <auto-generated />
using System;
using AnimalService.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AnimalService.Data.Migrations
{
    [DbContext(typeof(AnimalDbContext))]
    [Migration("20230714052928_update-animal-entity")]
    partial class UpdateAnimalEntity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AnimalService.Entities.Animal", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Breed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoverImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PublicId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PublicId"));

                    b.Property<string>("Sex")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4b22475e-dc6d-40be-866f-32f6aae242a9"),
                            Age = 2,
                            Breed = "Double doodle",
                            Color = "White",
                            CoverImageUrl = "https://placedog.net/500",
                            CreatedAt = new DateTime(2023, 7, 14, 5, 29, 28, 661, DateTimeKind.Utc).AddTicks(1420),
                            Description = "lorem ipsum",
                            Name = "Dee Dee",
                            PublicId = 1,
                            Sex = "Female",
                            Status = 0,
                            Type = "Dog",
                            UpdatedAt = new DateTime(2023, 7, 14, 5, 29, 28, 661, DateTimeKind.Utc).AddTicks(1420),
                            Weight = 10
                        },
                        new
                        {
                            Id = new Guid("62aa9d4a-40ea-46ab-9186-789618d5e014"),
                            Age = 5,
                            Breed = "Bengal cat",
                            Color = "Beige",
                            CoverImageUrl = "https://placekitten.com/200/200",
                            CreatedAt = new DateTime(2023, 7, 14, 5, 29, 28, 661, DateTimeKind.Utc).AddTicks(1450),
                            Description = "lorem ipsum",
                            Name = "Buttercup",
                            PublicId = 2,
                            Sex = "Male",
                            Status = 0,
                            Type = "Cat",
                            UpdatedAt = new DateTime(2023, 7, 14, 5, 29, 28, 661, DateTimeKind.Utc).AddTicks(1450),
                            Weight = 5
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
