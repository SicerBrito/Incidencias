using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration;
public class PersonalizadoConfiguration : IEntityTypeConfiguration<Personalizado>
{
    public void Configure(EntityTypeBuilder<Personalizado> builder)
    {
        builder.ToTable("Personalizacion");

        builder.Property(p => p.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_Personalizacion")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.Nombre)
            .HasColumnName("Nombre")
            .HasColumnType("varchar")
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(p => p.Descripcion)
            .HasColumnName("Descripcion")
            .HasColumnType("varchar")
            .HasMaxLength(255)
            .IsRequired();
    }
}
