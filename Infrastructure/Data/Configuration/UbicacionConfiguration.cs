using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration;
public class UbicacionConfiguration : IEntityTypeConfiguration<Ubicacion>
{
    public void Configure(EntityTypeBuilder<Ubicacion> builder)
    {
        builder.ToTable("Ubicaciones");

        builder.Property(p => p.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("IdUbicacion")
            .HasColumnType("int")
            .IsRequired();
        
        builder.Property(p => p.Nombre)
            .HasColumnName("NombreUbicacion")
            .HasColumnType("varchar")
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(p => p.IdArea)
            .HasColumnName("Area_Id")
            .HasColumnType("int")
            .IsRequired();

        builder.HasOne(a => a.Areas)
            .WithMany(u => u.Ubicaciones)
            .HasForeignKey(a => a.IdArea);


    }
}
