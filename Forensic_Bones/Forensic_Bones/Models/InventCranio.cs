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
        public string Descricao { get; set; }
        public int Frontal { get; set; }
        public int Ocipital { get; set; }
        public int Esfenoide { get; set; }
        public int Maxilar { get; set; }
        public int Palatino { get; set; }
        public int Vomer { get; set; }
        public int ParietalEsquerdo { get; set; }

        public int TemporalEsquerdo { get; set; }
        public int ConchaNasalInferiorEsquerda { get; set; }
        public int EtmoideEsquerdo { get; set; }
        public int LacrimalEsquerdo { get; set; }
        public int NasalEsquerdo { get; set; }
        public int ZigomaticoEsquerdo { get; set; }
        public int ParietalDireito { get; set; }
        public int TemporalDireito { get; set; }
        public int ConchaNasalInferiorDireita { get; set; }
        public int Etmoide { get; set; }
        public int LacrimalDireito { get; set; }
        public int ZigomaticoDireito { get; set; }
        public int Hioide { get; set; }
        public int CartilagemDaTireoide { get; set; }
        public int Mandibula { get; set; }






    }
}
