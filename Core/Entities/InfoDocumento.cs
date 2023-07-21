using System.ComponentModel.DataAnnotations;

namespace Core.Entities;
    public class InfoDocumento{
        
        [Key]
        public int IdInformacionPersonal { get; set; }
        public InformacionPersonal ? DatosPersonales { get; set; }
        public int IdDocumento { get; set; }
        public TipoDocumento ? Documentos { get; set; }


    }
