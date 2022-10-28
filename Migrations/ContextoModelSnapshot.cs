﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace RecursosHumanos.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.9");

            modelBuilder.Entity("Ausencias", b =>
                {
                    b.Property<int>("AusenciaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CantidadDias")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EmpleadoId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<string>("MotivoAusencia")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AusenciaId");

                    b.ToTable("Ausencias");
                });

            modelBuilder.Entity("Empleados", b =>
                {
                    b.Property<int>("EmpleadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Cedula")
                        .HasColumnType("TEXT");

                    b.Property<string>("Celular")
                        .HasColumnType("TEXT");

                    b.Property<string>("Departamento")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Direccion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("EstadoCivil")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("TEXT");

                    b.Property<string>("FormaPago")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float?>("Sueldo")
                        .IsRequired()
                        .HasColumnType("REAL");

                    b.Property<string>("Telefono")
                        .HasColumnType("TEXT");

                    b.HasKey("EmpleadoId");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("Licencias", b =>
                {
                    b.Property<int>("LicenciaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Caracteristica")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DiasReposo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("EmpleadoId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FechaEmision")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("TEXT");

                    b.Property<string>("LugarEmision")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NombreMedico")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TipoLicencia")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LicenciaId");

                    b.ToTable("Licencias");
                });

            modelBuilder.Entity("Nomina", b =>
                {
                    b.Property<int>("NominaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("EmpleadoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Forma_Pago")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("pago")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.HasKey("NominaId");

                    b.ToTable("Nomina");
                });

            modelBuilder.Entity("Permisos", b =>
                {
                    b.Property<int>("PermisoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CantidadDias")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EmpleadoId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<string>("MotivoPermiso")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PermisoId");

                    b.ToTable("Permisos");
                });
#pragma warning restore 612, 618
        }
    }
}
