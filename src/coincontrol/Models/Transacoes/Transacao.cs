using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace coincontrol.Models.Transacoes
{
    [Table("transacoes")]
    public class Transacao
    {
        [Key]
        [Column("idTransacoes")]
        public int IdTransacoes { get; set; }

        [Column("idCarteira")]
        [Required(ErrorMessage = "Obrigatório informar a carteira!")]
        public int IdCarteira { get; set; }

        [Column("idUsuario")]
        public int IdUsuario { get; set; }

        [Column("modalidade")]
        public Modalidade Modalidade { get; set; }

        [Column("valor")]
        [Required(ErrorMessage = "Obrigatório informar o valor!")]
        public float Valor { get; set; }

        [Column("date")]
        [Required(ErrorMessage = "Obrigatório informar a data!")]
        public DateTime Date { get; set; }

        [Column("idCategoria")]
        [Required(ErrorMessage = "Obrigatório informar a categoria!")]
        public int IdCategoria { get; set; }

        [Column("saldoInicial")]
        public float SaldoInicial { get; set; }

        [Column("saldoFinal")]
        public float SaldoFinal { get; set; }

        [Column("moeda")]
        public char Moeda { get; set; }
    }

    public enum Modalidade
    {
        [Display(Name = "Entrada")]
        ET,
        [Display(Name = "Saída")]
        SD
    }

}
