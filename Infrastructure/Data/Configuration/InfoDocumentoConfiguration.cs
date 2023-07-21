using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration;
public class TipoIncidenteConfiguration : IEntityTypeConfiguration<InfoDocumento>
{
    public void Configure(EntityTypeBuilder<InfoDocumento> builder)
    {
        builder.ToTable("InformacionDeDocumentos");

        builder.Property(p => p.IdInformacionPersonal)
            .HasColumnName("InformacionPersonal_Id")
            .HasColumnType("int")
            .IsRequired();
        
        builder.HasOne(u => u.DatosPersonales)
            .WithMany(i => i.InfoDeDocumentos)
            .HasForeignKey(u => u.IdInformacionPersonal);

        builder.Property(p => p.IdDocumento)
            .HasColumnName("Documento_Id")
            .HasColumnType("int")
            .IsRequired();
        
        builder.HasOne(u => u.DatosPersonales)
            .WithMany(i => i.InfoDeDocumentos)
            .HasForeignKey(u => u.IdDocumento);
    }
}