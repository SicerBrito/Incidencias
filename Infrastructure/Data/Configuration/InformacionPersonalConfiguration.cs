using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration;
public class InformacionPersonalConfiguration : IEntityTypeConfiguration<InformacionPersonal>
{
    public void Configure(EntityTypeBuilder<InformacionPersonal> builder)
    {
        builder.ToTable("DatosPersonales");

        builder.Property(p => p.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_Info")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.Nombres)
            .HasColumnName("Nombres")
            .HasColumnType("varchar")
            .HasMaxLength(150)
            .IsRequired();

        builder.Property(p => p.Apellidos)
           .HasColumnName("Apellidos")
           .HasColumnType("varchar")
           .HasMaxLength(150)
           .IsRequired();

        builder.Property(p => p.Documento)
           .HasColumnName("Documento")
           .HasColumnType("int")
           .IsRequired();

        builder.Property(p => p.IdGenero)
           .HasColumnName("Genero_ID")
           .HasColumnType("int")
           .IsRequired();

        builder.HasOne(p => p.Generos)
            .WithMany(i => i.DatosPersonales)
            .HasForeignKey(p => p.IdGenero);

        builder.Property(p => p.IdTelefono)
           .HasColumnName("Telefono_ID")
           .HasColumnType("int")
           .IsRequired();

        builder.HasOne(p => p.Telefonos)
            .WithMany(i => i.DatosPersonales)
            .HasForeignKey(p => p.IdTelefono);

    }
}
