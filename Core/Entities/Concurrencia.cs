using System.ComponentModel.DataAnnotations;

namespace Core.Entities;
    public class Concurrencia{

        [Key]
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public ICollection<PersonaIncidente> ? PersonasIncidentes { get; set; }

        
    }
