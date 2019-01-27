﻿// <auto-generated />
using System;
using ClinicaServicios.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClinicaServicios.Migrations
{
    [DbContext(typeof(ClinicContext))]
    [Migration("20190127195354_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ClinicaServicios.Features.Especializaciones.Especializacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("Int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("FechaTransaccion")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("FechaTransaccion")
                        .HasColumnType("DateTime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("ModificadoPor")
                        .IsRequired()
                        .HasColumnName("ModificadoPor")
                        .HasColumnType("Varchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("Nombre")
                        .HasColumnType("Varchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Especializaciones","Clinica");
                });
#pragma warning restore 612, 618
        }
    }
}
