using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Forensic_Bones.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "Campo obrigatório")]
        public string Senha { get; set; }


        [Required(ErrorMessage = "Campo obrigatório")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Campo obrigatório")]
        public string Funcao { get; set; }


    }
}
