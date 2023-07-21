using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class TipoIncidenteConfiguration : IEntityTypeConfiguration<TipoIncidente>
{
    public void Configure(EntityTypeBuilder<TipoIncidente> builder)
    {
        builder.ToTable("TiposDeIncidente");

        builder.Property(p => p.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_TipoDeIncidente")
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
