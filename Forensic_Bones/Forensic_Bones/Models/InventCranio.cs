using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Forensic_Bones.Models
{
    [Table("InventarioCranio")]
    public class InventCranio
    {
        [Key]
        public int Id { get; set; }

        public int InventEsqueletoId { get; set; }
        public InventEsqueleto InventEsqueleto { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        public int Frontal { get; set; }
        public int Ocipital { get; set; }
        [Display(Name = "Esfenóide")]
        public int Esfenoide { get; set; }
        public int Maxilar { get; set; }
        public int Palatino { get; set; }
        [Display(Name = "Vômer")]
        public int Vomer { get; set; }

        [Display(Name="Parietal Esquerdo")]
        public int ParietalEsquerdo { get; set; }
        [Display(Name ="Temporal Esquerdo")]
        public int TemporalEsquerdo { get; set; }
        [Display(Name ="Concha Nasal Inferior Esquerda")]
        public int ConchaNasalInferiorEsquerda { get; set; }
        [Display(Name = "Etmoide Esquerdo")]
        public int EtmoideEsquerdo { get; set; }
        [Display(Name = "Lacrimal Esquerdo")]
        public int LacrimalEsquerdo { get; set; }
        [Display(Name = "Nasal Esquerdo")]
        public int NasalEsquerdo { get; set; }
        [Display(Name = "Zigomático Esquerdo")]
        public int ZigomaticoEsquerdo { get; set; }
        [Display(Name = "Parietal Direito")]
        public int ParietalDireito { get; set; }
        [Display(Name = "Temporal Direito")]
        public int TemporalDireito { get; set; }
        [Display(Name = "Concha Nasal Inferior Direita")]
        public int ConchaNasalInferiorDireita { get; set; }
        [Display(Name = "Etmóide")]
        public int Etmoide { get; set; }
        [Display(Name = "Lacrimal Direito")]
        public int LacrimalDireito { get; set; }
        [Display(Name = "Zigomático Direito")]
        public int ZigomaticoDireito { get; set; }
        public int Hioide { get; set; }
        [Display(Name = "Cartilagem da Tireoide")]
        public int CartilagemDaTireoide { get; set; }
        [Display(Name = "Mandíbula")]
        public int Mandibula { get; set; }






    }
}
