﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WebApplicationBasic.DAL;

namespace Motochamp.Migrations
{
    [DbContext(typeof(MotoDbContext))]
    partial class MotoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplicationBasic.Models.Bike", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Brand");

                    b.Property<string>("Registration");

                    b.Property<int?>("UserId");

                    b.Property<string>("Year");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Bikes");
                });

            modelBuilder.Entity("WebApplicationBasic.Models.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BikeId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("BikeId");

                    b.ToTable("Models");
                });

            modelBuilder.Entity("WebApplicationBasic.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WebApplicationBasic.Models.Bike", b =>
                {
                    b.HasOne("WebApplicationBasic.Models.User")
                        .WithMany("Bikes")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("WebApplicationBasic.Models.Model", b =>
                {
                    b.HasOne("WebApplicationBasic.Models.Bike", "Bike")
                        .WithMany("Models")
                        .HasForeignKey("BikeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
