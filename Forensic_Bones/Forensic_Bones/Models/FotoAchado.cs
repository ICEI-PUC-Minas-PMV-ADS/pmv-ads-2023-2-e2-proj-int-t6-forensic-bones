using System.ComponentModel.DataAnnotations;

namespace Forensic_Bones.Models
{
    public class FotoAchado
    {
        // como colocar id do modelo do invent do esqueleto?
        [Key]
        public InventEsqueleto. { get; set; }
        // como fazer referência ao inventário do esqueleto?
        // public InventEsqueleto InventEsqueleto { get; set; }
        // public int InventEsqueletoId { get; set; }


        [Required(ErrorMessage = "Campo obrigatório")]
        public string Url { get; set; }

    }
}
