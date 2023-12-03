using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Forensic_Bones.Models
{
    [Table("Relatorios")]
    public class Relatorio
    {
        [Key]
        public int RelatorioId { get; set; }

        [Required(ErrorMessage = "Código do relatório obrigatório")]
        [Display(Name = "Código do Relatório")]
        [StringLength(45)]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "Obrigado informar a data")]
        [DataType(DataType.Date)]
        public DateTime Data { get; set; }

        [Display(Name = "Observações")]
        [StringLength(45)]
        public string Observacoes { get; set; }

        [Required(ErrorMessage = "Obrigado informar o Id do usuário")]
        [Display(Name = "Id do usuário")]
        public int UsuarioId { get; set; }

        // Relação com a entidade Usuario
        [ForeignKey("UsuarioId")]
        public virtual Usuario Usuario { get; set; }

        public virtual List<InventarioEsqueleto> InventariosEsqueleto { get; set; }
        public virtual List<InventarioCranio> InventarioCranio { get; set; }
        public virtual List<MarcadoresCranio> MarcadoresCranio { get; set; }

    }
}