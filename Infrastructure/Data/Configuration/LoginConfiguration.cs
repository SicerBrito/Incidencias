using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration;
public class LoginConfiguration : IEntityTypeConfiguration<Login>
{
    public void Configure(EntityTypeBuilder<Login> builder)
    {
        builder.ToTable("Logins");

        builder.Property(p => p.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_Login")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.IdEmail)
           .HasColumnName("Email_Id")
           .HasColumnType("int")
           .IsRequired();
        
        builder.HasOne(p => p.Emails)
            .WithMany(i => i.Logins)
            .HasForeignKey(p => p.IdEmail);

        builder.Property(p => p.Password)
            .HasColumnName("Password")
            .HasColumnType("varchar")
            .HasMaxLength(100)
            .IsRequired();


        builder.Property(p => p.IdCargo)
           .HasColumnName("Cargo_Id")
           .HasColumnType("int")
           .IsRequired();
        
        builder.HasOne(p => p.Cargos)
            .WithMany(i => i.Logins)
            .HasForeignKey(p => p.IdCargo);

        builder.Property(p => p.IdInfo)
           .HasColumnName("Info_Id")
           .HasColumnType("int")
           .IsRequired();
        
        builder.HasOne(p => p.DatosPersonales)
            .WithMany(i => i.Logins)
            .HasForeignKey(p => p.IdInfo);

        builder.Property(p => p.Created_at)
            .HasColumnName("Created_at")
            .HasColumnType("date")
            .IsRequired();
    }
}
