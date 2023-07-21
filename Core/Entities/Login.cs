using System.ComponentModel.DataAnnotations;

namespace Core.Entities;
    public class Login{
        
        [Key]
        public int Id { get; set; }
        public int IdEmail { get; set; }
        public Email ? Emails { get; set; }
        public string ? Password { get; set; }
        public int IdCargo { get; set; }
        public Cargo ? Cargos { get; set; }
        public int IdInfo { get; set; }
        public InformacionPersonal ? DatosPersonales { get; set; }
        public DateTime Created_at { get; set; }
        public ICollection<Incidencia> ? Incidencias { get; set; }


    }
