using System.ComponentModel.DataAnnotations;

namespace MvcCarteira.Models;

public class Carteira
{
    [Key]
    public int IdCarteira { get; set; }
    public float SaldoInicial { get; set; }
    public float SaldoParcial { get; set; }

    [Required(ErrorMessage = "Obrigatório informar o ano.")]
    public int Ano { get; set; }

    [Required(ErrorMessage = "Obrigatório informar o mês.")]
    public int Mes { get; set; }

}