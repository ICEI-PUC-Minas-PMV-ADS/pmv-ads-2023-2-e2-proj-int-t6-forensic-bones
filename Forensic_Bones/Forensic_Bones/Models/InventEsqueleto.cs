using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Forensic_Bones.Models
{
    [Table("InventarioEsqueleto")]
    public class InventEsqueleto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public int QuantidadeDeOssos { get; set; }
        public string Data { get; set; } = DateTime.Now.ToString("dd/MM/yyyy");
    }
}
