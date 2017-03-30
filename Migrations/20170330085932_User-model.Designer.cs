using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WebApplicationBasic.DAL;

namespace Motochamp.Migrations
{
    [DbContext(typeof(MotoDbContext))]
    [Migration("20170330085932_User-model")]
    partial class Usermodel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
        }
    }
}
