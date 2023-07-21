using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration;
public class TelefonoConfiguration : IEntityTypeConfiguration<Telefono>
{
    public void Configure(EntityTypeBuilder<Telefono> builder)
    {
        builder.ToTable("Telefonos");

        builder.Property(p => p.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_Telefono")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.Numero)
            .HasColumnName("Numero")
            .HasColumnType("int")
            .IsRequired();
    }
}
