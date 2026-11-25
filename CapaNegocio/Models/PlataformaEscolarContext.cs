using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CapaNegocio.Models;

public partial class PlataformaEscolarContext : DbContext
{
    public PlataformaEscolarContext()
    {
    }

    public PlataformaEscolarContext(DbContextOptions<PlataformaEscolarContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Alumno> Alumnos { get; set; }

    public virtual DbSet<Cargo> Cargos { get; set; }

    public virtual DbSet<Grado> Grados { get; set; }

    public virtual DbSet<Materia> Materias { get; set; }

    public virtual DbSet<Nota> Notas { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Alumno>(entity =>
        {
            entity.HasKey(e => e.IdAlumno).HasName("PK__ALUMNOS__460B4740CCFD7F41");

            entity.ToTable("ALUMNOS");

            entity.Property(e => e.Apellidos)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombres)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdGradoNavigation).WithMany(p => p.Alumnos)
                .HasForeignKey(d => d.IdGrado)
                .HasConstraintName("FK_Alumnos_Grado");

            entity.HasOne(d => d.IdMateriaNavigation).WithMany(p => p.Alumnos)
                .HasForeignKey(d => d.IdMateria)
                .HasConstraintName("FK_Alumnos_Materias");
        });

        modelBuilder.Entity<Cargo>(entity =>
        {
            entity.HasKey(e => e.IdCargo).HasName("PK__CARGOS__6C985625C9E4DB46");

            entity.ToTable("CARGOS");

            entity.Property(e => e.Cargo1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Cargo");
        });

        modelBuilder.Entity<Grado>(entity =>
        {
            entity.HasKey(e => e.IdGrado).HasName("PK__Grados__393DFCB8B512BC8D");

            entity.Property(e => e.Grado1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Grado");
            entity.Property(e => e.Seccion)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Turno)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Materia>(entity =>
        {
            entity.HasKey(e => e.IdMaterias).HasName("PK__MATERIAS__94356E5F864BBC62");

            entity.ToTable("MATERIAS");

            entity.Property(e => e.Materia1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Materia");
        });

        modelBuilder.Entity<Nota>(entity =>
        {
            entity.HasKey(e => e.IdNota).HasName("PK__NOTAS__4B2ACFF27AE9DA08");

            entity.ToTable("NOTAS");

            entity.Property(e => e.FechaRegistro).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.IdAlumnoNavigation).WithMany(p => p.Nota)
                .HasForeignKey(d => d.IdAlumno)
                .HasConstraintName("FK_Notas_Alumno");

            entity.HasOne(d => d.IdGradoNavigation).WithMany(p => p.Nota)
                .HasForeignKey(d => d.IdGrado)
                .HasConstraintName("FK_Notas_Grado");

            entity.HasOne(d => d.IdMateriaNavigation).WithMany(p => p.Nota)
                .HasForeignKey(d => d.IdMateria)
                .HasConstraintName("FK_Notas_Materias");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__USUARIOS__5B65BF970826046D");

            entity.ToTable("USUARIOS");

            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Clave)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DocumentoIdentidad)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Usuario1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Usuario");

            entity.HasOne(d => d.IdCargoNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdCargo)
                .HasConstraintName("FK_Usuarios_Cargo");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
