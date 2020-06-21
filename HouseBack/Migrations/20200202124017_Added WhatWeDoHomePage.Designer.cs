﻿// <auto-generated />
using System;
using HouseBack.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HouseBack.Migrations
{
    [DbContext(typeof(HouseDbContext))]
    [Migration("20200202124017_Added WhatWeDoHomePage")]
    partial class AddedWhatWeDoHomePage
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HouseBack.Models.HomeBanner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<string>("Image")
                        .HasMaxLength(200);

                    b.Property<bool>("Status");

                    b.HasKey("Id");

                    b.ToTable("HomeBanners");
                });

            modelBuilder.Entity("HouseBack.Models.WhatWeDoHomePage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<string>("Header")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(200);

                    b.Property<bool>("Status");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("WhatWeDoHomePages");
                });
#pragma warning restore 612, 618
        }
    }
}
