using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace coincontrol.Models.TransacoesTestes
{    
        [Table("transacoesTestes")]
        public class TransacaoTeste
        {
                         
            [Key]
            [Column("idTransacao")]
            public int IdTransacao { get; set; }

            [Column("idUsuario")]
            public int IdUsuario { get; set; }

            [Column("idCarteira")]
            public int IdCarteira { get; set; }

            [Column("valor")]            
            [Required(ErrorMessage = "Obrigatório informar o valor!")]
            public float Valor { get; set; }

            [Column("data")]
            [Required(ErrorMessage = "Obrigatório informar a data e a hora!")]
            public DateTime Date { get; set; }

            [Column("idCategoria")]
            [Required(ErrorMessage = "Obrigatório informar a categoria!")]
            public IdCategoria IdCategoria { get; set; }
                        
            [Column("modalidade")]            
            public Modalidade Modalidade { get; set; }
                             
        }

        public enum Modalidade
        {
            Entrada,
            Saída
        }

        public enum IdCategoria
        {
            Alimentação,
            Educação,
            Lazer,
            Saúde,    
            Transportes,
            Salário,
            Ganhos,
            Outros              
        }

}
