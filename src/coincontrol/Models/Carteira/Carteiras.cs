
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace coincontrol.Models.Carteira
{
    [Table("carteiras")]
    public class Carteiras
    {
        [Key]
        [Column("IdCarteira")]
        public int IdCarteira { get; set; }

        [Column("IdUsuario")]
        public int IdUsuario { get; set; }

        [Column("SaldoInicial")]
        public float SaldoInicial { get; set; }

        [Column("SaldoParcial")]
        public float SaldoParcial { get; set; }

        [Column("Ano")]
        [Required(ErrorMessage = "Obrigatório informar o ano.")]
        public int Ano { get; set; }

        [Column("Mes")]
        [Required(ErrorMessage = "Obrigatório informar o mês.")]
        public int Mes { get; set; }
    }
}

