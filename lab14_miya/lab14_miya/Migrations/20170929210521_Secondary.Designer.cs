﻿// <auto-generated />
using lab14_miya.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace lab14_miya.Migrations
{
    [DbContext(typeof(lab14_miyaContext))]
    [Migration("20170929210521_Secondary")]
    partial class Secondary
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("lab14_miya.Models.Register", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("FavoriteClass");

                    b.Property<int>("Grade");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Talent");

                    b.HasKey("ID");

                    b.ToTable("Register");
                });
#pragma warning restore 612, 618
        }
    }
}
