﻿// <auto-generated />
using System;
using APITienda.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APITienda.Migrations
{
    [DbContext(typeof(BdtenisContext))]
    partial class BdtenisContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("APITienda.Models.Teni", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Categoria")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("categoria");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imagen")
                        .HasMaxLength(355)
                        .IsUnicode(false)
                        .HasColumnType("varchar(355)")
                        .HasColumnName("imagen");

                    b.Property<string>("Nombre")
                        .HasMaxLength(355)
                        .IsUnicode(false)
                        .HasColumnType("varchar(355)")
                        .HasColumnName("nombre");

                    b.Property<decimal?>("Precio")
                        .HasColumnType("decimal(10, 2)")
                        .HasColumnName("precio");

                    b.HasKey("Id")
                        .HasName("PK__Tenis__3213E83F02902286");

                    b.ToTable("Tenis");
                });
#pragma warning restore 612, 618
        }
    }
}
