﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Database.Migrations
{
    [DbContext(typeof(CalcDbContext))]
    [Migration("20240422104735_ModifTypeValue")]
    partial class ModifTypeValue
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("Calculus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Operateur")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("Value1")
                        .HasColumnType("REAL");

                    b.Property<float>("Value2")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Calculus");
                });
#pragma warning restore 612, 618
        }
    }
}
