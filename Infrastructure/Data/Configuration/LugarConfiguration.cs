using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration;
public class LugarConfiguration : IEntityTypeConfiguration<Lugar>
{
    public void Configure(EntityTypeBuilder<Lugar> builder)
    {
        builder.ToTable("Lugares");

        builder.Property(p => p.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("IdLugar")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.Nombre)
            .HasColumnName("NombreLugar")
            .HasColumnType("varchar")
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(p => p.Descripcion)
            .HasColumnName("DescripcionLugar")
            .HasColumnType("varchar")
            .HasMaxLength(255)
            .IsRequired();


    }
}
