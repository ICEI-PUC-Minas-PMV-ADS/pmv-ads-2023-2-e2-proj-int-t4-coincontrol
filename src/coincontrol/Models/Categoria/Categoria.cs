using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace coincontrol.Models.categoria
{
    [Table("categorias")]
    public class Categoria
    {
        [Key]
        [Column("idCategoria")]
        public int IdCategoria { get; set; }

        [Column("nome")]
        [Required(ErrorMessage = "Obrigatório informar o nome!")]
        [MaxLength(45)]
        public string Nome { get; set; }

        [Column("limite")]
        [Required(ErrorMessage = "Obrigatório informar o limite de gastos!")]
        [MaxLength(10)]
        public float Limite { get; set; }

        [Column("idUsuario")]
        public int IdUsuario {  get; set; }

    }
}
