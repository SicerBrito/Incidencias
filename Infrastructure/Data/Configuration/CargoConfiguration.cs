using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration;
public class CargoConfiguration : IEntityTypeConfiguration<Cargo>
{
    public void Configure(EntityTypeBuilder<Cargo> builder)
    {
        builder.ToTable("Rols");

        builder.Property(p => p.IdCargo)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("IdRols")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.Nombre)
            .HasColumnName("NombreDelRol")
            .HasColumnType("varchar")
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(p => p.Descripcion)
           .HasColumnName("DescripcionDelRol")
           .HasColumnType("varchar")
           .HasMaxLength(255)
           .IsRequired();

        
    }
}
