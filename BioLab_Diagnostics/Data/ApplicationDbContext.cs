using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BioLab_Diagnostics.Data
{
    public class ApplicationDbContext : IdentityDbContext<Usuario>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
        }
    }
    public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.Property(u => u.Nombre).HasMaxLength(256).IsRequired();
            builder.Property(u => u.Apellidos).HasMaxLength(256).IsRequired();
            builder.Property(u => u.FechaNacimiento).IsRequired();
            builder.Property(u => u.Sexo).HasMaxLength(1).IsRequired();
            builder.Property(u => u.Imagen).HasMaxLength(300);
		}
	}
}
