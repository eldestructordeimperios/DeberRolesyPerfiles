using System;
using System.Collections.Generic;
using DeberRolesyPerfiles.Models;
using Microsoft.EntityFrameworkCore;

namespace DeberRolesyPerfiles.Context;

public partial class BaseAdoContext : DbContext
{
    public BaseAdoContext()
    {
    }

    public BaseAdoContext(DbContextOptions<BaseAdoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<Manga> Mangas { get; set; }

    public virtual DbSet<Opcione> Opciones { get; set; }

    public virtual DbSet<OpcionesXRole> OpcionesXRoles { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<UsuarioXRole> UsuarioXRoles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-HB9THRM\\SQLEXPRESS; Database=BASE_ADO; Trusted_Connection=True; Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.Cedula).HasName("PK__EMPLEADO__06BB8449584F6B16");

            entity.ToTable("EMPLEADO");

            entity.Property(e => e.Cedula)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CEDULA");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("APELLIDOS");
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DIRECCION");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.FechaNacimineto).HasColumnName("FECHA_NACIMINETO");
            entity.Property(e => e.Nombres)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRES");
            entity.Property(e => e.Sueldo)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("SUELDO");
        });

        modelBuilder.Entity<Manga>(entity =>
        {
            entity.HasKey(e => e.CodManga).HasName("PK__MANGA__45D6FAB09E1391BF");

            entity.ToTable("MANGA");

            entity.Property(e => e.CodManga)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("COD_MANGA");
            entity.Property(e => e.Autor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("AUTOR");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.FechaCreacion).HasColumnName("FECHA_CREACION");
            entity.Property(e => e.Genero)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GENERO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("PRECIO");
        });

        modelBuilder.Entity<Opcione>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OPCIONES__3214EC2714F8D984");

            entity.ToTable("OPCIONES");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.NombreFormulario)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_FORMULARIO");
        });

        modelBuilder.Entity<OpcionesXRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OPCIONES__3214EC27C5D90207");

            entity.ToTable("OPCIONES_X_ROLES");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.IdOpcion).HasColumnName("ID_OPCION");
            entity.Property(e => e.IdRol).HasColumnName("ID_ROL");

            entity.HasOne(d => d.IdOpcionNavigation).WithMany(p => p.OpcionesXRoles)
                .HasForeignKey(d => d.IdOpcion)
                .HasConstraintName("FK__OPCIONES___ID_OP__5165187F");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.OpcionesXRoles)
                .HasForeignKey(d => d.IdRol)
                .HasConstraintName("FK__OPCIONES___ID_RO__52593CB8");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ROLES__3214EC27433CF2BF");

            entity.ToTable("ROLES");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Codigo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__USUARIOS__3214EC276BBF99AF");

            entity.ToTable("USUARIOS");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("APELLIDOS");
            entity.Property(e => e.Codigo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Contrasena)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CONTRASENA");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.Nombres)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("NOMBRES");
        });

        modelBuilder.Entity<UsuarioXRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__USUARIO___3214EC27AE584B59");

            entity.ToTable("USUARIO_X_ROLES");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.IdRol).HasColumnName("ID_ROL");
            entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.UsuarioXRoles)
                .HasForeignKey(d => d.IdRol)
                .HasConstraintName("FK__USUARIO_X__ID_RO__4E88ABD4");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.UsuarioXRoles)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK__USUARIO_X__ID_US__4D94879B");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
