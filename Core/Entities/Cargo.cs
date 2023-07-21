using System.ComponentModel.DataAnnotations;

namespace Core.Entities;
    public class Cargo{

        [Key]
        public int IdCargo { get; set; }
        public string ? Nombre { get; set; }
        public string ? Descripcion { get; set; }
        public ICollection<Login> ? Logins { get; set; }

    }
