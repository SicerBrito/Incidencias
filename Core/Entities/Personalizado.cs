using System.ComponentModel.DataAnnotations;

namespace Core.Entities;
    public class Personalizado{

        [Key]
        public int Id { get; set; }
        public string ? Nombre { get; set; }
        public string ? Descripcion { get; set; }
        public ICollection<Genero> ? Generos { get; set; }

        
    }
