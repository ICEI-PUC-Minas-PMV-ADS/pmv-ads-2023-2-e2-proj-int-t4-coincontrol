using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public float ValorTotal { get; set; }

        [Column("valorParcial")]
        public float ValorParcial { get; set; }

        [Column("idUsuario")]
        public int IdUsuario { get; set; }

        [Column("idCategoria")]
        [Required(ErrorMessage = "Obrigatório informar a categoria!")]
        public int IdCategoria { get; set; }

    }
}
