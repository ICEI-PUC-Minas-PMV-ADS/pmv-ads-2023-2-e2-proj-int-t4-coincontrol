using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace coincontrol.Models.categoria
{
    [Table("categoria")]
    public class categoria
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
        public float Email { get; set; }

    }
}
