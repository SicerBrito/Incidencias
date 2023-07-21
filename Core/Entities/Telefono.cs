using System.ComponentModel.DataAnnotations;

namespace Core.Entities;
    public class Telefono{

        [Key]
        public int Id { get; set; }
        public int Numero { get; set;}
        public ICollection<InformacionPersonal> ? DatosPersonales { get; set; }

        
    }
