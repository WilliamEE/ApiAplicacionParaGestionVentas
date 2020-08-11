﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using backend;

namespace backend.Migrations
{
    [DbContext(typeof(GestionVentasBDContext))]
    [Migration("20200811045105_Creación de tabla clientes")]
    partial class Creacióndetablaclientes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("backend.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("character varying");

                    b.HasKey("Id");

                    b.HasIndex("Nombre")
                        .IsUnique()
                        .HasName("UQ_Categoria_Nombre");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("backend.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasColumnType("character varying(600)")
                        .HasMaxLength(600);

                    b.Property<bool>("Credito")
                        .HasColumnType("boolean");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("character varying(600)")
                        .HasMaxLength(600);

                    b.Property<string>("Documento")
                        .HasColumnType("character varying(25)")
                        .HasMaxLength(25);

                    b.Property<string>("Email")
                        .HasColumnType("character varying(600)")
                        .HasMaxLength(600);

                    b.Property<string>("Imagen")
                        .HasColumnType("character varying(600)")
                        .HasMaxLength(600);

                    b.Property<decimal?>("MontoCredito")
                        .HasColumnType("numeric(18,2)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("character varying(300)")
                        .HasMaxLength(300);

                    b.Property<string>("Observacion")
                        .HasColumnType("character varying(600)")
                        .HasMaxLength(600);

                    b.Property<string>("TelefonoMovil")
                        .IsRequired()
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<string>("TelefonoSec")
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("backend.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Codigo")
                        .HasColumnType("character varying(300)")
                        .HasMaxLength(300);

                    b.Property<decimal?>("Costo")
                        .HasColumnType("numeric(18,2)");

                    b.Property<int?>("IdCategoria")
                        .HasColumnType("integer");

                    b.Property<string>("Imagen")
                        .HasColumnType("character varying(600)")
                        .HasMaxLength(600);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("character varying(300)")
                        .HasMaxLength(300);

                    b.Property<decimal>("Precio")
                        .HasColumnType("numeric(18,2)");

                    b.Property<decimal?>("PrecioPromocional")
                        .HasColumnType("numeric(18,2)");

                    b.Property<string>("Unidad")
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<bool?>("VerCatalogo")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("IdCategoria");

                    b.ToTable("Producto");
                });

            modelBuilder.Entity("backend.Producto", b =>
                {
                    b.HasOne("backend.Categoria", "IdCategoriaNavigation")
                        .WithMany("Producto")
                        .HasForeignKey("IdCategoria")
                        .HasConstraintName("Fk_Producto_Categoria");
                });
#pragma warning restore 612, 618
        }
    }
}
