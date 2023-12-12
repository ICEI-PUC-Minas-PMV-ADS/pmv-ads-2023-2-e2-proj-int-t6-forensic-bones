using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ForensicBones100.Models
{
        [Table("Usuarios")]
        public class Usuario
        {
            [Key]
            public int UsuarioId { get; set; }

            [Required(ErrorMessage = "Obrigatório informar o nome")]
            
            public string Nome { get; set; }

            [Required(ErrorMessage = "Insira um e-mail válido")]
            [Display(Name = "E-mail")]
            
            public string Email { get; set; }

            [Required(ErrorMessage = "Obrigatório informar a senha")]
            [DataType(DataType.Password)]
            
            public string Senha { get; set; }

            public string Cargo { get; set; }
            public Perfil Perfil { get; set; }
        }

        public enum Perfil
        {
            Admin,
            User
        }
}