using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace coincontrol.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; } // Temos que salvar a CategoryId nessa Transaction entity

        [Range(1, int.MaxValue, ErrorMessage = "Favor selecionar uma categoria.")]

        public int CategoryId { get; set; }
        public Category? Categoria { get; set; }
       
        [Range(1, int.MaxValue, ErrorMessage = "O valor deve ser acima de R$0.")]

        public int Valor { get; set; }

        [Column(TypeName = "nvarchar(75)")]
        public string? Descrição { get; set; }

        public DateTime Data { get; set; } = DateTime.Now;
        [NotMapped]
        public string? TituloCategoriaComIcone
        {
            get
            {
                return Categoria == null ? "" : Categoria.Ícone + " " + Categoria.Título;
            }
        }

        [NotMapped]
        public string? FormattedAmount
        {
            get
            {
                return ((Categoria == null || Categoria.Modalidade == "Saída") ? "- " : "+ ") + Valor.ToString("C0");
            }
        }
    }
}
