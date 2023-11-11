using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using coincontrol.Models.Usuario;

namespace coincontrol.Models.TransacoesA
{    
        [Table("transacoesA")]
        public class TransacoesA    
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
            public int IdCategoria { get; set; }
                        
            [Column("modalidade")]            
            public Modalidade Modalidade { get; set; }
                             
        }

        public enum Modalidade
        {
            Entrada,
            Saída
        }

}
