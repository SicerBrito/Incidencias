using System.Reflection;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;
    public class IncidenciaContext : DbContext{
        public IncidenciaContext(DbContextOptions<IncidenciaContext> options) : base (options){

        }

        public DbSet<Area> ? Areas { get; set; }
        public DbSet<Cargo> ? Cargos { get; set; }
        public DbSet<Concurrencia> ? Concurrencias { get; set; }
        public DbSet<Email> ? Emails { get; set; }
        public DbSet<Incidencia> ? Incidencias { get; set; }
        public DbSet<InfoDocumento>? InfoDeDocumentos { get; set; }
        public DbSet<InformacionPersonal> ? DatosPersonales { get; set; }
        public DbSet<Login> ? Logins { get; set; }
        public DbSet<Lugar> ? Lugares { get; set; }
        public DbSet<PersonaIncidente> ? PersonasIncidentes { get; set; }
        public DbSet<Personalizado> ? Personalizaciones { get; set; }
        public DbSet<Genero> ? Generos { get; set; }
        public DbSet<Telefono> ? Telefonos { get; set; }
        public DbSet<TipoDocumento> ? TiposDeDocumentos { get; set; }
        public DbSet<TipoIncidente> ? TiposDeIncidentes { get; set; }
        public DbSet<Ubicacion> ? Ubicaciones { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder){
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        
    }
