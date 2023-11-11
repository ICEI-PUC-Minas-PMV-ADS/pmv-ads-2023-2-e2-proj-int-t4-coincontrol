using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using coincontrol.Models.Usuario;
using System.Text;

namespace coincontrol.Models.TransacoesA
{    
        [Table("transacoesA")]
        public class TransacoesA    
        {
                         
            [Key]
            [Column("idTransacao")]
            [Display(Name = "N° da Transação")]
            public int IdTransacao { get; set; }

            [Column("idUsuario")]
            [Display(Name = "Usuário")]
            public int IdUsuario { get; set; }
            
            [Column("idCarteira")]
            [Display(Name = "Carteira")]
            public int IdCarteira { get; set; }

            [Column("valor")]
            [Display(Name = "Valor")]
            [Required(ErrorMessage = "Obrigatório informar o valor!")]
        
            public float Valor { get; set; }

            [Column("data")]
            [Display(Name = "Data e Hora")]
            [Required(ErrorMessage = "Obrigatório informar a data e a hora!")]
            public DateTime Date { get; set; }

            [Column("idCategoria")]
            [Display(Name = "Categoria")]
            [Required(ErrorMessage = "Obrigatório informar a categoria!")]
            public int IdCategoria { get; set; }
                        
            [Column("modalidade")]
            [Display(Name = "Modalidade")]
            public Modalidade Modalidade { get; set; }
                             
        }

        public enum Modalidade
        {
            Entrada,
            Saída
        }

}
