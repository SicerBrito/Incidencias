using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration;
public class AreaConfiguration : IEntityTypeConfiguration<Area>
{

    public void Configure(EntityTypeBuilder<Area> builder)
    {
        builder.ToTable("Areas");

        builder.Property(p => p.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_Area")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.Entrenamiento)
            .HasColumnName("AreaEntrenamiento")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.Review)
            .HasColumnName("AreaReview")
            .HasColumnType("int")
            .IsRequired();




        builder.Property(p => p.IdLugar)
            .HasColumnName("Lugar_Id")
            .HasColumnType("int")
            .IsRequired();

        builder.HasOne(r => r.Lugares)
            .WithMany(a => a.Areas)
            .HasForeignKey(r => r.IdLugar);
    }
}
