using System.ComponentModel.DataAnnotations;

namespace Core.Entities;
    public class TipoIncidente{
        
        [Key]
        public int Id { get; set; }
        public string ? Nombre { get; set; }
        public string ? Descripcion { get; set; }
        public ICollection<Incidencia> ? Incidencias { get; set; }


    }
