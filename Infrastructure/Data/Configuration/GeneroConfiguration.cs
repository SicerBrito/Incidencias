using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration;
public class GeneroConfiguration : IEntityTypeConfiguration<Genero>
{
    public void Configure(EntityTypeBuilder<Genero> builder)
    {
        builder.ToTable("Generos");

        builder.Property(p => p.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_Genero")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.Hombre)
            .HasColumnName("Masculino")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.Mujer)
            .HasColumnName("Femenino")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.Privado)
            .HasColumnName("Privado")
            .HasColumnType("int")
            .IsRequired();
        
        builder.Property(p => p.IdPersonalizado)
            .HasColumnName("Personalizacion_Id")
            .HasColumnType("int")
            .IsRequired();
        
        builder.HasOne(p => p.Personalizacion)
            .WithMany(g => g.Generos)
            .HasForeignKey(p => p.IdPersonalizado);
    }
}
