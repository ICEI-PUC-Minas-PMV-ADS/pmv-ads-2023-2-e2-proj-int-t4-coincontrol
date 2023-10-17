using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace coincontrol.Models.Carteira
{
    [Table("carteiras")]
    public class Carteira
    {
        [Key]
        [Column("IdCarteira")]
        public int IdCarteira { get; set; }

        [Column("IdUsuario")]
        public int IdUsuario { get; set; }

        [Column("SaldoInicial")]
        public float SaldoInicial { get; set; }

        [Column("SaldoFinal")]
        public float SaldoFinal { get; set; }

        [Column("Ano")]
        public int Ano { get; set; }

        [Column("Mes")]
        public int Mes { get; set; }
    }
}