using System.ComponentModel.DataAnnotations;

namespace Core.Entities;
    public class PersonaIncidente{
        
        [Key]
        public int Id { get; set; }
        public int IdInfo { get; set; }
        public InformacionPersonal ? DatosPersonales { get; set; }
        public int IdConcurrencia { get; set; }
        public Concurrencia ? Concurrencias { get; set; }
        public ICollection<Incidencia> ? Incidencias { get; set; }


    }
