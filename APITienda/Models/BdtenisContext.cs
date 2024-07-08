using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace APITienda.Models;

public partial class BdtenisContext : DbContext
{
    public BdtenisContext()
    {
    }

    public BdtenisContext(DbContextOptions<BdtenisContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Teni> Tenis { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            // Puedes lanzar una excepción o registrar un mensaje si lo prefieres
#warning The connection string should be configured in Program.cs
        }
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Teni>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Tenis__3213E83F02902286");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Categoria)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("categoria");
            entity.Property(e => e.Imagen)
                .HasMaxLength(355)
                .IsUnicode(false)
                .HasColumnName("imagen");
            entity.Property(e => e.Nombre)
                .HasMaxLength(355)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
