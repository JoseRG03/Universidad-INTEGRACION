﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectoUniversidad.Context;

#nullable disable

namespace ProyectoUniversidad.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20240412004856_v5")]
    partial class v5
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProyectoUniversidad.Models.Estudiante", b =>
                {
                    b.Property<int>("estudiante_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("estudiante_id"));

                    b.Property<int>("carrera_id")
                        .HasColumnType("int");

                    b.Property<int>("cuenta_id")
                        .HasColumnType("int");

                    b.Property<bool>("estudiante_activo")
                        .HasColumnType("bit");

                    b.Property<string>("estudiante_apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estudiante_correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estudiante_documento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("estudiante_fecha_ingreso")
                        .HasColumnType("date");

                    b.Property<decimal>("estudiante_indice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("estudiante_nacionalidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estudiante_nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estudiante_telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("estudiante_trimestre")
                        .HasColumnType("int");

                    b.Property<int>("tipo_documento_id")
                        .HasColumnType("int");

                    b.HasKey("estudiante_id");

                    b.ToTable("Estudiantes");
                });

            modelBuilder.Entity("ProyectoUniversidad.Models.Servicio", b =>
                {
                    b.Property<int>("servicio_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("servicio_id"));

                    b.Property<decimal>("servicio_costo")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("servicio_nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("servicio_id");

                    b.HasIndex("servicio_nombre")
                        .IsUnique();

                    b.ToTable("Servicios");
                });
#pragma warning restore 612, 618
        }
    }
}