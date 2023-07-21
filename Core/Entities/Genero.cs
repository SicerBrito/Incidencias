using System.ComponentModel.DataAnnotations;

namespace Core.Entities;
    public class Genero{

        [Key]
        public int Id { get; set; }
        public int Hombre { get; set; }
        public int Mujer { get; set; }
        public int Privado { get; set; }
        public int IdPersonalizado { get; set; }
        public Personalizado ? Personalizacion { get; set; }
        public ICollection<InformacionPersonal> ? DatosPersonales { get; set; }


    }
