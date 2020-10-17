﻿// <auto-generated />
using System;
using Azure.Api.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Azure.Api.Migrations
{
    [DbContext(typeof(ColegioContext))]
    [Migration("20201015221156_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Azure.Api.Core.Entidades.Alumno", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Apellido")
                        .HasColumnType("Varchar(40)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("Varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Alumno");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2396bc71-fc3b-4204-ac8d-d1df35cf904c"),
                            Apellido = "Fuentes",
                            FechaNacimiento = new DateTime(1995, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Josep"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}