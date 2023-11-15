using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace coincontrol.Models.Meta
{
    [Table("metas")]
    public class Meta
    {
        [Key]
        [Column("idMeta")]
        public int IdMeta { get; set; }

        [Column("valorTotal")]
        [Required(ErrorMessage = "Obrigatório informar o valor da meta!")]
        [Display(Name = "Valor da Meta")]
        public decimal ValorTotal { get; set; }

        [Column("valorParcial")]
        [Display(Name = "Valor Atual")]
        public decimal ValorParcial { get; set; }

        [Display(Name = "Categoria")]
        [Required(ErrorMessage = "Obrigatório informar a categoria!")]
        [NotMapped]
        public int IdCategoria { get; set; }

        [ForeignKey("idCategoria")]
        public Category Categoria { get; set; }

        [ForeignKey("idUsuario")]
        public Usuario.Usuario Usuario { get; set; }

    }
}
