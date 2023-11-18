using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace coincontrol.Models.Carteira
{
    [Table("carteira")]
    public class Carteira
    {
        [Key]
        [Column("idCarteira")]
        public int idCarteira { get; set; }

        [Column("idUsuario")]
        public int idUsuario { get; set; }

        [Column("saldoInicial")]
        public decimal saldoInicial { get; set; }

        [Column("saldoParcial")]
        public decimal saldoParcial { get; set; }

        [Column("ano")]
        [Required(ErrorMessage = "Obrigatório informar o ano.")]
        public int ano { get; set; }

        [Column("mes")]
        [Required(ErrorMessage = "Obrigatório informar o mês.")]
        public int mes { get; set; }

        [ForeignKey("idUsuario")]
        public Usuario.Usuario Usuario { get; set; }
    }
}



