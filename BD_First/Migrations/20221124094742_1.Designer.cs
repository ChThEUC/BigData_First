﻿// <auto-generated />
using System;
using BD_First.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BDFirst.Migrations
{
    [DbContext(typeof(BD_FirstContext))]
    [Migration("20221124094742_1")]
    partial class _1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("BD_First.Models.IngestModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<bool>("UsingTimer")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("IngestModel");
                });

            modelBuilder.Entity("BD_First.Models.WeatherModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Latitude")
                        .HasColumnType("REAL");

                    b.Property<float>("Longitude")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("TEXT");

                    b.Property<string>("WindDir")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("WindMax10")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("WindMax3")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("WindMean")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("WeatherModel");
                });
#pragma warning restore 612, 618
        }
    }
}
