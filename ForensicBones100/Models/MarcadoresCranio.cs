using ForensicBones100.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ForensicBones100.Models
{
    [Table("MarcadoresCranio")]
    public class MarcadoresCranio
    {
        [Key]
        public int MarcadoresCranioId { get; set; }

        [Required]
        [Display(Name = "Código do Relatório")]
        public int RelatorioMarcadoresId { get; set; }

        [Display(Name = "Crista Nucal")]
        public char CristaNucal { get; set; }
        public string CristaNucalDesc { get; set; }

        [Display(Name = "Processo Mastoide")]
        public char ProcessoMastoide { get; set; }
        public string ProcessoMastoideDesc { get; set; }

        [Display(Name = "Eminência Mentoniana")]
        public char EminenciaMentoniana { get; set; }
        public string EminenciaMentonianaDesc { get; set; }

        [Display(Name = "Margem Supra-Orbital")]
        public char SupraOrbital { get; set; }
        public string SupraOrbitalDesc { get; set; }

        [Display(Name = "Área da Glabela")]
        public char AreaGlabela { get; set; }
        public string AreaGlabelaDesc { get; set; }
        public string CalculoEstimativaSexo { get; set; }

        public string Observacoes { get; set; }

        // Relação com a entidade Relatorio
        [ForeignKey("RelatorioMarcadoresId")]
        public virtual Relatorio Relatorio { get; set; }

    }
}