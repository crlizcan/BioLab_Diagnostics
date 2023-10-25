using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BioLab_Diagnostics.Models
{
    public partial class BioLab_DiagnosticsContext : DbContext
    {
        public BioLab_DiagnosticsContext()
        {
        }

        public BioLab_DiagnosticsContext(DbContextOptions<BioLab_DiagnosticsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Cita> Cita { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Departamentos> Departamentos { get; set; }
        public virtual DbSet<Peticiones> Peticiones { get; set; }
        public virtual DbSet<PeticionesPruebas> PeticionesPruebas { get; set; }
        public virtual DbSet<Pruebas> Pruebas { get; set; }
        public virtual DbSet<ValoresReferencia> ValoresReferencia { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-U8CLU4K;Database=BioLab_Diagnostics;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.FechaNacimiento).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.Imagen).HasMaxLength(300);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.PasswordHash).IsRequired();

                entity.Property(e => e.Sexo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<Cita>(entity =>
            {
                entity.HasKey(e => e.IdCita)
                    .HasName("PK__Cita__7C17FD163319F2B2");

                entity.Property(e => e.IdCita).HasColumnName("ID_Cita");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(11)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Clientes>(entity =>
            {
                entity.HasKey(e => e.Dni)
                    .HasName("PK__Clientes__C035B8DC683B77CD");

                entity.Property(e => e.Dni)
                    .HasColumnName("DNI")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnName("Fecha_nacimiento")
                    .HasColumnType("date");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Departamentos>(entity =>
            {
                entity.HasKey(e => e.IdDepartamento)
                    .HasName("PK__Departam__249DEFBED127B5A4");

                entity.Property(e => e.IdDepartamento).HasColumnName("ID_Departamento");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Peticiones>(entity =>
            {
                entity.HasKey(e => e.IdPeticion)
                    .HasName("PK__Peticion__8F8A7F777587F922");

                entity.Property(e => e.IdPeticion).HasColumnName("ID_Peticion");

                entity.Property(e => e.DniCliente)
                    .IsRequired()
                    .HasColumnName("DNI_Cliente")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FechaInforme)
                    .HasColumnName("Fecha_informe")
                    .HasColumnType("date");

                entity.Property(e => e.FechaVisita)
                    .HasColumnName("Fecha_visita")
                    .HasColumnType("date");

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.DniClienteNavigation)
                    .WithMany(p => p.Peticiones)
                    .HasForeignKey(d => d.DniCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Peticione__DNI_C__06CD04F7");
            });

            modelBuilder.Entity<PeticionesPruebas>(entity =>
            {
                entity.HasKey(e => e.IdPeticionPrueba)
                    .HasName("PK__Peticion__A6BC4C0B4222944E");

                entity.Property(e => e.IdPeticionPrueba).HasColumnName("ID_PeticionPrueba");

                entity.Property(e => e.IdPeticion).HasColumnName("ID_Peticion");

                entity.Property(e => e.IdPrueba).HasColumnName("ID_Prueba");

                entity.Property(e => e.Resultado)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPeticionNavigation)
                    .WithMany(p => p.PeticionesPruebas)
                    .HasForeignKey(d => d.IdPeticion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Peticione__ID_Pe__09A971A2");

                entity.HasOne(d => d.IdPruebaNavigation)
                    .WithMany(p => p.PeticionesPruebas)
                    .HasForeignKey(d => d.IdPrueba)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Peticione__ID_Pr__0A9D95DB");
            });

            modelBuilder.Entity<Pruebas>(entity =>
            {
                entity.HasKey(e => e.IdPrueba)
                    .HasName("PK__Pruebas__FCB047EEF85F251B");

                entity.Property(e => e.IdPrueba).HasColumnName("ID_Prueba");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IdDepartamento).HasColumnName("ID_Departamento");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Precio).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Unidades)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdDepartamentoNavigation)
                    .WithMany(p => p.Pruebas)
                    .HasForeignKey(d => d.IdDepartamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Pruebas__ID_Depa__01142BA1");
            });

            modelBuilder.Entity<ValoresReferencia>(entity =>
            {
                entity.HasKey(e => e.IdReferencia)
                    .HasName("PK__Valores___C15263C529E7FC17");

                entity.ToTable("Valores_Referencia");

                entity.Property(e => e.IdReferencia).HasColumnName("ID_Referencia");

                entity.Property(e => e.IdPrueba).HasColumnName("ID_Prueba");

                entity.Property(e => e.Sexo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ValorReferencia)
                    .IsRequired()
                    .HasColumnName("Valor_Referencia")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPruebaNavigation)
                    .WithMany(p => p.ValoresReferencia)
                    .HasForeignKey(d => d.IdPrueba)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Valores_R__ID_Pr__03F0984C");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
