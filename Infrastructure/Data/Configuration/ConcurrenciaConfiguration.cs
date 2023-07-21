using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration;
public class ConcurrenciaConfiguration : IEntityTypeConfiguration<Concurrencia>
{
    public void Configure(EntityTypeBuilder<Concurrencia> builder)
    {
        builder.ToTable("Concurrencias");

        builder.Property(p => p.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_Concurrencia")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.Cantidad)
            .HasColumnName("CantidadDeConcurrencias")
            .HasColumnType("int")
            .IsRequired();


    }
}
