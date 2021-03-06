﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using zadangular234.Models.Data;

namespace zadangular234.Migrations
{
    [DbContext(typeof(SamochodyContext))]
    [Migration("20200513121106_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("zadangular234.Models.Samochody", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("KM")
                        .HasColumnType("TEXT");

                    b.Property<string>("Marka")
                        .HasColumnType("TEXT");

                    b.Property<string>("Model")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sciezka")
                        .HasColumnType("TEXT");

                    b.Property<string>("Silnik")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Samochody");
                });
#pragma warning restore 612, 618
        }
    }
}
