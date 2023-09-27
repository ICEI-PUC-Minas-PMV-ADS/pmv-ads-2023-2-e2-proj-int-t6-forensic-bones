using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Forensic_Bones.Models
{
    [Table("FotografiasEsqueleto")]    
    public class FotoEsqueleto
    {
        [Key]
        public int id { get; set; }
        public int InventEsqueletoId { get; set; }
        public InventEsqueleto InventEsqueleto { get; set; }


        [Required(ErrorMessage = "Campo obrigatório")]
        public string Url { get; set; }
    }
}
