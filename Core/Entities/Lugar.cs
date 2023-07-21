using System.ComponentModel.DataAnnotations;

namespace Core.Entities;
    public class Lugar{

        [Key]
        public int Id { get; set; }
        public string ? Nombre { get; set; }
        public string ? Descripcion { get; set; }
        public ICollection<Area> ? Areas { get; set; }
        
        
    }
