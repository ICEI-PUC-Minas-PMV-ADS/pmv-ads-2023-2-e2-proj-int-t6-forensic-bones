using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ForensicBones100.Models
{
    [Table("InventarioCranio")]
    public class InventarioCranio
    {
        [Key]
        public int InventarioCranioId { get; set; }

        [Required]
        [Display(Name = "Código do Relatório")]
        public int RelatorioCranioId { get; set; }

        public int Frontal { get; set; }

        [Display(Name = "Descrição")]
        public string FrontalDesc { get; set; }

        public int Ocipital { get; set; }
        [Display(Name = "Observações")]
        public string OcipitalDesc { get; set; }

        public int Esfenoide { get; set; }

        [Display(Name = "Observações")]
        public string EsfenoideDesc { get; set; }

        public int Maxilar { get; set; }

        [Display(Name = "Observações")]
        public string MaxilarDesc { get; set; }

        public int Vomer { get; set; }

        [Display(Name = "Observações")]
        public string VomerDesc { get; set; }

        [Display(Name = "Parietal Esquerdo")]
        public int ParietalEsquerdo { get; set; }

        [Display(Name = "Observações")]
        public string ParietalEsquerdoDesc { get; set; }

        [Display(Name = "Temporal Esquerdo")]
        public int TemporalEsquerdo { get; set; }

        [Display(Name = "Observações")]
        public string TemporalEsquerdoDesc { get; set; }

        [Display(Name = "Concha Nasal Inferior Esquerda")]
        public int ConchaNasalInferiorEsquerda { get; set; }

        [Display(Name = "Observações")]
        public string ConchaNasalInferiorEsquerdaDesc { get; set; }

        public int Etmoide { get; set; }

        [Display(Name = "Observações")]
        public string EtmoideDesc { get; set; }

        [Display(Name = "Lacrimal Esquerdo")]
        public int LacrimalEsquerdo { get; set; }

        [Display(Name = "Observações")]
        public string LacrimalEsquerdoDesc { get; set; }

        [Display(Name = "Nasal Esquerdo")]
        public int NasalEsquerdo { get; set; }

        [Display(Name = "Observações")]
        public string NasalEsquerdoDesc { get; set; }

        [Display(Name = "Zigomático Esquerdo")]
        public int ZigomaticoEsquerdo { get; set; }

        [Display(Name = "Observações")]
        public string ZigomaticoEsquerdoDesc { get; set; }

        [Display(Name = "Parietal Direito")]
        public int ParietalDireito { get; set; }

        [Display(Name = "Observações")]
        public string ParietalDireitoDesc { get; set; }

        [Display(Name = "Temporal Direito")]
        public int TemporalDireito { get; set; }

        [Display(Name = "Observações")]
        public string TemporalDireitoDesc { get; set; }

        [Display(Name = "Concha Nasal Inferior Direita")]
        public int ConchaNasalInferiorDireita { get; set; }

        [Display(Name = "Observações")]
        public string ConchaNasalInferiorDireitaDesc { get; set; }

        [Display(Name = "Lacrimal Direito")]
        public int LacrimalDireito { get; set; }

        [Display(Name = "Observações")]
        public string LacrimalDireitoDesc { get; set; }

        [Display(Name = "Nasal Direito")]
        public int NasalDireito { get; set; }

        [Display(Name = "Observações")]
        public string NasalDireitoDesc { get; set; }

        [Display(Name = "Zigomático Direito")]
        public int ZigomaticoDireito { get; set; }

        [Display(Name = "Observações")]
        public string ZigomaticoDireitoDesc { get; set; }

        public int Hioide { get; set; }

        [Display(Name = "Observações")]
        public string HioideDesc { get; set; }

        [Display(Name = "Cartilagem da Tireoide")]
        public int CartilagemTireoide { get; set; }

        [Display(Name = "Observações")]
        public string CartilagemTireoideDesc { get; set; }

        [Display(Name = "Mandíbula")]
        public int Mandibula { get; set; }

        [Display(Name = "Observações")]
        public string MandibulaDesc { get; set; }

        [Display(Name = "Observações Gerais")]
        public string Observacoes { get; set; }

        [Display(Name = "Fotos do Crânio")]
        public string FotosCranio { get; set; }

        // Relação com a entidade Relatorio
        [ForeignKey("RelatorioCranioId")]
        public virtual Relatorio Relatorio { get; set; }
        public virtual List<MarcadoresCranio> MarcadoresCranio { get; set; }

    }
}