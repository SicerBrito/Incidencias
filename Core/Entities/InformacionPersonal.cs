using System.ComponentModel.DataAnnotations;

namespace Core.Entities;
    public class InformacionPersonal{
        
        [Key]
        public int Id { get; set; }
        public string ? Nombres { get; set; }
        public string ? Apellidos { get; set; }
        public int Documento { get; set; }
        public int IdGenero { get; set; }
        public Genero ? Generos { get; set; }
        public int IdTelefono { get; set; }
        public Telefono ? Telefonos { get; set; }
        public ICollection<Login> ? Logins { get; set; }
        public ICollection<PersonaIncidente> ? PersonasIncidentes { get; set; }
        public ICollection<InfoDocumento> ? InfoDeDocumentos { get; set; }
        
    }
