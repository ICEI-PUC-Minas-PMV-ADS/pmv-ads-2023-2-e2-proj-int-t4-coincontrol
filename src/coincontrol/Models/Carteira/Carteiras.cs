using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcCarteira.Models
{
    public class Carteira
    {
        [Key]
        [Column("idCarteira")]
        public int IdCarteira { get; set; }

        [Column("ano")]
        [Required(ErrorMessage = "Obrigatório informar o ano.")]
        public int Ano { get; set; }

        [Column("mes")]
        [Required(ErrorMessage = "Obrigatório informar o mês.")]
        public int Mes { get; set; }

        [Column("saldoInicial")]
        public float SaldoInicial { get; set; }

        [Column("saldoParcial")]
        public float SaldoParcial { get; set; }

        [Column("idUsuario")]
        public int IdUsuario { get; set; }

    }
}