using System.ComponentModel.DataAnnotations;

namespace Core.Entities;
    public class Ubicacion{

        [Key]
        public int Id { get; set; }
        public string ? Nombre { get; set; }
        public int IdArea { get; set; }
        public Area ? Areas { get; set; }
        public ICollection<Incidencia> ? Incidencias { get; set; }
        
        
    }
