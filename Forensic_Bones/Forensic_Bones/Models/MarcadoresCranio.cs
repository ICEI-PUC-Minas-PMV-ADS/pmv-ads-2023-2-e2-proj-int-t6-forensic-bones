using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Forensic_Bones.Models
{
    [Table("MarcadoresCranio")]
    public class MarcadoresCranio
    {

        [Key]
        public int MarcadoresCranioId { get; set; }

        [Required]
        [Display(Name = "Código do Relatório")]
        public int RelatorioId { get; set; }

        [Display(Name = "Crista Nucal")]
        public char CristaNucal { get; set; }

        [Display(Name = "Processo Mastoide")]
        public char ProcessoMastoide { get; set; }

        [Display(Name = "Eminência Mentoniana")]
        public char EminenciaMentoniana { get; set; }

        [Display(Name = "Supra Orbital")]
        public char SupraOrbital { get; set; }

        [Display(Name = "Área da Glabela")]
        public char AreaGlabela { get; set; }

        [Display(Name = "Observações")]
        public string Observacoes { get; set; }

        [ForeignKey("RelatorioId")]
        public virtual Relatorio Relatorio { get; set; }
        public InventarioCranio InventarioCranio { get; set; }
    }
}