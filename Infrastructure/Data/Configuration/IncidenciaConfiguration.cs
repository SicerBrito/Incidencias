using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration;
public class IncidenciaConfiguration : IEntityTypeConfiguration<Incidencia>
{
    public void Configure(EntityTypeBuilder<Incidencia> builder)
    {
        builder.ToTable("Incidencias");

        builder.Property(p => p.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_Incidencia")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.IdUsuario)
            .HasColumnName("Usuario_Id")
            .HasColumnType("int")
            .IsRequired();
        
        builder.HasOne(u => u.Logins)
            .WithMany(i => i.Incidencias)
            .HasForeignKey(u => u.IdUsuario);

        builder.Property(p => p.IdPersonaIncidente)
           .HasColumnName("PersonaIncidente_Id")
           .HasColumnType("int")
           .IsRequired();
        
        builder.HasOne(p => p.PersonasIncidentes)
            .WithMany(i => i.Incidencias)
            .HasForeignKey(p => p.IdPersonaIncidente);

        builder.Property(p => p.IdTipoIncidencia)
           .HasColumnName("TipoIncidencia_Id")
           .HasColumnType("int")
           .IsRequired();
        
        builder.HasOne(t => t.TiposDeIncidentes)
            .WithMany(i => i.Incidencias)
            .HasForeignKey(t => t.IdTipoIncidencia);

        builder.Property(p => p.IdUbicacion)
           .HasColumnName("Ubicacion_Id")
           .HasColumnType("int")
           .IsRequired();
        
        builder.HasOne(u => u.Ubicaciones)
            .WithMany(i => i.Incidencias)
            .HasForeignKey(u => u.IdUbicacion);

        builder.Property(p => p.FechaIncidente)
          .HasColumnName("Created_at")
          .HasColumnType("date")
          .IsRequired();

    }
}
