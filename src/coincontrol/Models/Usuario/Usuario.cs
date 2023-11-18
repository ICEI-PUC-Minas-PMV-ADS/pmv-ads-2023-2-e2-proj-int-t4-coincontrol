using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace coincontrol.Models.Usuario
{
    [Table("usuarios")]
    public class Usuario
    {
        [Key]
        [Column("idUsuario")]
        public int idUsuario { get; set; }

        [Column("nome")]
        [Required(ErrorMessage = "Obrigatório informar o nome!")]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Column("email")]
        [Required(ErrorMessage = "Obrigatório informar o email!")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(100)]
        public string Email { get; set; }

        [Column("senha")]
        [Required(ErrorMessage = "Obrigatório informar a senha!")]
        [DataType(DataType.Password)]
        [MaxLength(100)]
        public string Senha { get; set; }
    }
}
