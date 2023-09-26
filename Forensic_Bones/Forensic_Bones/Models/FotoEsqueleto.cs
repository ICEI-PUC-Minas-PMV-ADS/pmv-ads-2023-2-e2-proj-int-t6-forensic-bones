using System.ComponentModel.DataAnnotations;

namespace Forensic_Bones.Models
{
    public class FotoEsqueleto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Url { get; set; }
    }
}
