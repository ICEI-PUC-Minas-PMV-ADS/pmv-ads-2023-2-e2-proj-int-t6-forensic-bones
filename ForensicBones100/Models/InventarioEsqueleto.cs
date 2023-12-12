using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ForensicBones100.Models
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
        
        public string FotoEsqueleto { get; set; }

        [Display(Name = "Observações")]
        public string ObservacoesEsq { get; set; }

        // Relação com a entidade Relatorio
        [ForeignKey("RelatorioId")]
        [Display(Name = "Relatório")]
        public virtual Relatorio Relatorio { get; set; }

        public virtual List<InventarioCranio> InventarioCranio { get; set; }
    }
}