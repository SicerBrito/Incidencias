using System.ComponentModel.DataAnnotations;

namespace Core.Entities;
    public class Incidencia{

        [Key]
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public Login ? Logins { get; set; }
        public int IdPersonaIncidente { get; set; }
        public PersonaIncidente ? PersonasIncidentes { get; set; }
        public int IdTipoIncidencia { get; set; }
        public TipoIncidente ? TiposDeIncidentes { get; set; }
        public int IdUbicacion { get; set; }
        public Ubicacion ? Ubicaciones { get; set; }
        public DateTime FechaIncidente { get; set; }
        
    }