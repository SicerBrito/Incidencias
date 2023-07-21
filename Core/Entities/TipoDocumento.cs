using System.ComponentModel.DataAnnotations;

namespace Core.Entities;
    public class TipoDocumento{
        
        [Key]
        public int Id { get; set; }
        public string ? Nombre { get; set; }
        public string ? Abreviatura { get; set; }
        public ICollection<TipoDocumento> ? TipoDeDocumentos { get; set; }


    }
