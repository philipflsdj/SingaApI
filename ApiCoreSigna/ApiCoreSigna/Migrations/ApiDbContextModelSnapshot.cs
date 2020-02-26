﻿// <auto-generated />
using System;
using ApiCoreSigna.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ApiCoreSigna.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    partial class ApiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("ApiCoreSigna.Model.Cat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int?>("ownerIdId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ownerIdId");

                    b.ToTable("Cats");
                });

            modelBuilder.Entity("ApiCoreSigna.Model.Dog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int?>("ownerIdId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ownerIdId");

                    b.ToTable("Dogs");
                });

            modelBuilder.Entity("ApiCoreSigna.Model.Owner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("owners");
                });

            modelBuilder.Entity("ApiCoreSigna.Model.Cat", b =>
                {
                    b.HasOne("ApiCoreSigna.Model.Owner", "ownerId")
                        .WithMany()
                        .HasForeignKey("ownerIdId");
                });

            modelBuilder.Entity("ApiCoreSigna.Model.Dog", b =>
                {
                    b.HasOne("ApiCoreSigna.Model.Owner", "ownerId")
                        .WithMany()
                        .HasForeignKey("ownerIdId");
                });
#pragma warning restore 612, 618
        }
    }
}
