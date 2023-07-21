using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration;
public class PersonaIncidenteConfiguration : IEntityTypeConfiguration<PersonaIncidente>
{
    public void Configure(EntityTypeBuilder<PersonaIncidente> builder)
    {
        builder.ToTable("PersonasIncidentes");

        builder.Property(p => p.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_Incidencia")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.IdInfo)
            .HasColumnName("Info_Id")
            .HasColumnType("int")
            .IsRequired();
        
        builder.HasOne(u => u.DatosPersonales)
            .WithMany(i => i.PersonasIncidentes)
            .HasForeignKey(u => u.IdInfo);
        
        builder.Property(p => p.IdConcurrencia)
            .HasColumnName("Concurrencia_Id")
            .HasColumnType("int")
            .IsRequired();
        
        builder.HasOne(u => u.Concurrencias)
            .WithMany(i => i.PersonasIncidentes)
            .HasForeignKey(u => u.IdConcurrencia);
    }
}
