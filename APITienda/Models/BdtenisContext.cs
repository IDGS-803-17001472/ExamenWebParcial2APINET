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
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=FER\\SQLEXPRESS; Initial Catalog=BDTenis; user id=sa; password=root;TrustServerCertificate=true");

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
