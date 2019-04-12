﻿// <auto-generated />
using System;
using HotelWeb.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HotelWeb.Migrations
{
    [DbContext(typeof(HotelDbContext))]
    partial class HotelDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HotelWeb.Models.Apartment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ApartmentTypeId");

                    b.Property<int>("Capacity");

                    b.Property<int>("Number");

                    b.Property<bool>("Status");

                    b.HasKey("Id");

                    b.HasIndex("ApartmentTypeId");

                    b.ToTable("Apartments");
                });

            modelBuilder.Entity("HotelWeb.Models.ApartmentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Price");

                    b.HasKey("Id");

                    b.ToTable("ApartmentTypes");
                });

            modelBuilder.Entity("HotelWeb.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("HotelWeb.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<Guid>("Password");

                    b.Property<string>("Patronymic")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("RoleId");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("HotelWeb.Models.UserVisitor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("UserId");

                    b.Property<int?>("VisitorId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("VisitorId");

                    b.ToTable("UserVisitors");
                });

            modelBuilder.Entity("HotelWeb.Models.Visitor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ApartmentId");

                    b.Property<DateTime>("CheckIn");

                    b.Property<DateTime>("CheckOut");

                    b.HasKey("Id");

                    b.HasIndex("ApartmentId");

                    b.ToTable("Visitors");
                });

            modelBuilder.Entity("HotelWeb.Models.Apartment", b =>
                {
                    b.HasOne("HotelWeb.Models.ApartmentType", "ApartmentTypes")
                        .WithMany("Apartments")
                        .HasForeignKey("ApartmentTypeId");
                });

            modelBuilder.Entity("HotelWeb.Models.User", b =>
                {
                    b.HasOne("HotelWeb.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId");
                });

            modelBuilder.Entity("HotelWeb.Models.UserVisitor", b =>
                {
                    b.HasOne("HotelWeb.Models.User", "User")
                        .WithMany("UserVisitors")
                        .HasForeignKey("UserId");

                    b.HasOne("HotelWeb.Models.Visitor", "Visitor")
                        .WithMany("UserVisitors")
                        .HasForeignKey("VisitorId");
                });

            modelBuilder.Entity("HotelWeb.Models.Visitor", b =>
                {
                    b.HasOne("HotelWeb.Models.Apartment", "Apartment")
                        .WithMany("Visitors")
                        .HasForeignKey("ApartmentId");
                });
#pragma warning restore 612, 618
        }
    }
}
