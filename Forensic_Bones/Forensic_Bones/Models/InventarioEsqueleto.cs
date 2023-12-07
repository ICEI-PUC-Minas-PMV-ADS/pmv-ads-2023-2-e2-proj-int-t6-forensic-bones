using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Forensic_Bones.Models
{
    [Table("InventariosEsqueleto")]
    public class InventarioEsqueleto
    {
        [Key]
        public int InventarioEsqueletoId { get; set; }

        [Required]
        [Display(Name = "Código do Relatório")]
        public int RelatorioId { get; set; }

        [Display(Name = "Fotos do Esqueleto")]
        [StringLength(45)]
        public string FotoEsqueleto { get; set; }

        [Display(Name = "Observações")]
        [StringLength(45)]
        public string ObservacoesEsq { get; set; }

        // Relação com a entidade Relatorio
        [ForeignKey("RelatorioId")]
        public virtual Relatorio Relatorio { get; set; }

        public virtual List<InventarioCranio> InventarioCranio { get; set; }
    }
}