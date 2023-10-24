﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WorkShopI2;

#nullable disable

namespace WorkShopI2.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231024121251_addMesure2")]
    partial class addMesure2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WorkShopI2.Models.Mesures.Mesure", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("DateHeure")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Humidite")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ParkId")
                        .HasColumnType("int");

                    b.Property<string>("Temperature")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ParkId");

                    b.ToTable("Mesures");
                });

            modelBuilder.Entity("WorkShopI2.Models.Parks.Park", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Latitude")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Longitude")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VillesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VillesId");

                    b.ToTable("Parks");
                });

            modelBuilder.Entity("WorkShopI2.Models.Villes.Ville", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Villes");
                });

            modelBuilder.Entity("WorkShopI2.Models.WeatherForecast.WeatherForecast", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TemperatureC")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("WeatherForecasts");
                });

            modelBuilder.Entity("WorkShopI2.Models.Mesures.Mesure", b =>
                {
                    b.HasOne("WorkShopI2.Models.Parks.Park", "Park")
                        .WithMany("Mesures")
                        .HasForeignKey("ParkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Park");
                });

            modelBuilder.Entity("WorkShopI2.Models.Parks.Park", b =>
                {
                    b.HasOne("WorkShopI2.Models.Villes.Ville", "Villes")
                        .WithMany("Parks")
                        .HasForeignKey("VillesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Villes");
                });

            modelBuilder.Entity("WorkShopI2.Models.Parks.Park", b =>
                {
                    b.Navigation("Mesures");
                });

            modelBuilder.Entity("WorkShopI2.Models.Villes.Ville", b =>
                {
                    b.Navigation("Parks");
                });
#pragma warning restore 612, 618
        }
    }
}