using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Veterinaria.Models;

public partial class VeterinariaContext : DbContext
{
    public VeterinariaContext()
    {
    }

    public VeterinariaContext(DbContextOptions<VeterinariaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Comidum> Comida { get; set; }

    public virtual DbSet<Dueño> Dueños { get; set; }

    public virtual DbSet<Mascota> Mascotas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=HowenXD\\SQLEXPRESS;Database=Veterinaria; Trusted_Connection=True; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Comidum>(entity =>
        {
            entity.HasKey(e => e.IdComida);

            entity.Property(e => e.IdComida).HasColumnName("id_comida");
            entity.Property(e => e.Marca)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreProducto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Producto");
            entity.Property(e => e.TipoComida)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Tipo_Comida");
        });

        modelBuilder.Entity<Dueño>(entity =>
        {
            entity.HasKey(e => e.IdDueño);

            entity.Property(e => e.IdDueño).HasColumnName("id_dueño");
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Genero)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreMascota)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Mascota");
            entity.Property(e => e.NumeroTelefonico)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Numero_Telefonico");
            entity.Property(e => e.TipoMacota)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Tipo_Macota");
        });

        modelBuilder.Entity<Mascota>(entity =>
        {
            entity.HasKey(e => e.IdMascotas);

            entity.Property(e => e.IdMascotas).HasColumnName("id_mascotas");
            entity.Property(e => e.Especie)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Raza)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sexo)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
