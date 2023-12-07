using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Forensic_Bones.Models
{
    [Table("InventariosCranio")]
    public class InventarioCranio
    {
        [Key]
        public int InventarioCranioId { get; set; }

        [Required]
        [Display(Name = "Código do Relatório")]
        public int RelatorioId { get; set; }

        [Display(Name = "Código do Inventário")]
        public string InventarioEsqueletoId { get; set; }

        [Display(Name = "Fotos do Crânio")]
        public string FotoCranio { get; set; }

        [Display(Name = "Observações")]
        public string Observacoes { get; set; }

        public int Frontal { get; set; }
        public int Ocipital { get; set; }
        public int Esfenoide { get; set; }
        public int Maxilar { get; set; }
        public int Vomer { get; set; }
        [Display(Name = "Parietal Esquerdo")]
        public int ParietalEsq { get; set; }
        [Display(Name = "Temporal Esquerdo")]
        public int TemporalEsq { get; set; }
        [Display(Name = "Concha Nasal Esquerda")]
        public int ConchaNasalEsq { get; set; }
        [Display(Name = "Etmoide Esquerdo")]
        public int EtmoideEsq { get; set; }
        [Display(Name = "Lacrimal Esquerdo")]
        public int LacrimalEsq { get; set; }
        [Display(Name = "Nasal Esquerdo")]
        public int NasalEsq { get; set; }
        [Display(Name = "Zigomatico Esquerdo")]
        public int ZigomaticoEsq { get; set; }
        [Display(Name = "Parietal Direito")]
        public int ParietalDir { get; set; }
        [Display(Name = "Temporal Direito")]
        public int TemporalDir { get; set; }
        [Display(Name = "Concha Nasal Direito")]
        public int ConchaNasalDir { get; set; }
        [Display(Name = "Etmoide Direito")]
        public int EtmoideDir { get; set; }
        [Display(Name = "Lacrimal Direito")]
        public int LacrimalDir { get; set; }
        [Display(Name = "Zigomático Direito")]
        public int ZigomaticoDir { get; set; }
        public int Hioide { get; set; }

        [Display(Name = "Cartilagem Tireóide")]
        public int CartilagemTireoide { get; set; }

        [Display(Name = "Mandíbula")]
        public int Mandibula { get; set; }

        [Display(Name = "Fontal")]
        public string FrontalDesc { get; set; }
        [Display(Name = "Ocipital")]
        public string OcipitalDesc { get; set; }
        [Display(Name = "Esfenoide")]
        public string EsfenoideDesc { get; set; }
        [Display(Name = "Maxilar")]
        public string MaxilarDesc { get; set; }
        [Display(Name = "Vômer")]
        public string VomerDesc { get; set; }
        [Display(Name = "Parietal Esquerdo")]
        public string ParietalEsqDesc { get; set; }
        [Display(Name = "Temporal Esquerdo")]
        public string TemporalEsqDesc { get; set; }
        [Display(Name = "Concha Nasal Esquerda")]
        public string ConchaNasalEsqDesc { get; set; }
        [Display(Name = "Etmoide Esquerdo")]
        public string EtmoideEsqDesc { get; set; }
        [Display(Name = "Lacrimal Esquerdo")]
        public string LacrimalEsqDesc { get; set; }
        [Display(Name = "Nasal Esquerdo")]
        public string NasalEsqDesc { get; set; }
        [Display(Name = "Zigomatico Esquerdo")]
        public string ZigomaticoEsqDesc { get; set; }
        [Display(Name = "Parietal Direito")]
        public string ParietalDirDesc { get; set; }
        [Display(Name = "Temporal Direito")]
        public string TemporalDirDesc { get; set; }
        [Display(Name = "Concha Nasal Direito")]
        public string ConchaNasalDirDesc { get; set; }
        [Display(Name = "Etmoide Direito")]
        public string EtmoideDirDesc { get; set; }
        [Display(Name = "Lacrimal Direito")]
        public string LacrimalDirDesc { get; set; }
        [Display(Name = "Zigomático Direito")]
        public string ZigomaticoDirDesc { get; set; }
        [Display(Name = "Hioide")]
        public string HioideDesc { get; set; }

        [Display(Name = "Cartilagem Tireóide")]
        public string CartilagemTireoideDesc { get; set; }

        [Display(Name = "Mandíbula")]
        public string MandibulaDesc { get; set; }

        public InventarioEsqueleto InventarioEsqueleto { get; set; }

        // Relação com a entidade Relatorio
        [ForeignKey("RelatorioId")]
        public virtual Relatorio Relatorio { get; set; }
    }
}