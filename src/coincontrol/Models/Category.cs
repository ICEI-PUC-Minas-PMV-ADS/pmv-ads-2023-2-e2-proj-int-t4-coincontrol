using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace coincontrol.Models
{
    public class Category
    {
        [Key] //primary key
        public int CategoryId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "Favor inserir Título.")]
        public string Título { get; set; }

        [Column(TypeName = "nvarchar(5)")]
        public string Ícone { get; set; } = "";

        [Column(TypeName = "nvarchar(10)")]
        public string Modalidade { get; set; } = "Saída";

        [NotMapped]
        public string? TituloComIcone
        {
            get
            {
                return this.Ícone + " " + this.Título;
            }
        }
    }
}
