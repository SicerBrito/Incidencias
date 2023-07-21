using System.ComponentModel.DataAnnotations;

namespace Core.Entities;
    public class Area{
    
        [Key]
        public int Id { get; set; }
        public int Entrenamiento { get; set; }
        public int Review { get; set; }
        public int IdLugar { get; set; }
        public Lugar ? Lugares { get; set; }
        public ICollection<Ubicacion> ? Ubicaciones { get; set; }

    }
