using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using coincontrol.CCDbContext;
using coincontrol.Models;
using System.Globalization;

namespace coincontrol.Controllers
{
    public class DashboardController : Controller
    {
        private readonly CoinControlBdContext _context;

        public DashboardController(CoinControlBdContext context)
        {
            _context = context;
        }
        public async Task<ActionResult> Index()
        {
            //Ultimos 7 dias
            DateTime StartDate = DateTime.Today.AddDays(-6);
            DateTime EndDate = DateTime.Today;

            List<Transaction> SelectedTransactions = await _context.Transactions
                .Include(x => x.Categoria)
                .Where(y => y.Data >= StartDate && y.Data <= EndDate)
                .ToListAsync();

            //Ganho Total
            int TotalIncome = SelectedTransactions
                .Where(i => i.Categoria.Modalidade == "Entrada")
                .Sum(j => j.Valor);
            ViewBag.TotalIncome = TotalIncome.ToString("C0");

            //Gastos Total
            int TotalExpense = SelectedTransactions
                .Where(i => i.Categoria.Modalidade == "Saída")
                .Sum(j => j.Valor);
            ViewBag.TotalExpense = TotalExpense.ToString("C0");

            //Balanço
            int Balance = TotalIncome - TotalExpense;
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");
            culture.NumberFormat.CurrencyNegativePattern = 1;
            ViewBag.Balance = String.Format(culture, "{0:C0}", Balance);

            //Gráfico de Rosca - Gastos por Categoria
            ViewBag.DoughnutChartData = SelectedTransactions
                .Where(i => i.Categoria.Modalidade == "Saída")
                .GroupBy(j => j.Categoria.CategoryId)
                .Select(k => new
                {
                    TituloCategoriaComIcone = k.First().Categoria.Ícone + " " + k.First().Categoria.Título,
                    valor = k.Sum(j => j.Valor),
                    formattedAmount = k.Sum(j => j.Valor).ToString("C0"),
                })
                .OrderByDescending(l => l.valor)
                .ToList();

            //Gráfico Spline - Entrada vs Saída

            //Entrada
            List<SplineChartData> IncomeSummary = SelectedTransactions
                .Where(i => i.Categoria.Modalidade == "Entrada")
                .GroupBy(j => j.Data)
                .Select(k => new SplineChartData()
                {
                    dia = k.First().Data.ToString("dd-MMM"),
                    entrada = k.Sum(l => l.Valor)
                })
                .ToList();

            //Saída
            List<SplineChartData> ExpenseSummary = SelectedTransactions
                .Where(i => i.Categoria.Modalidade == "Saída")
                .GroupBy(j => j.Data)
                .Select(k => new SplineChartData()
                {
                    dia = k.First().Data.ToString("dd-MMM"),
                    saida = k.Sum(l => l.Valor)
                })
                .ToList();
           
            //Combinar Entrada & Saída
            string[] Last7Days = Enumerable.Range(0, 7)
                .Select(i => StartDate.AddDays(i).ToString("dd-MMM"))
                .ToArray();

            ViewBag.SplineChartData = from dia in Last7Days
                                      join entrada in IncomeSummary on dia equals entrada.dia into diaEntradaAgrupado
                                      from entrada in diaEntradaAgrupado.DefaultIfEmpty()
                                      join saida in ExpenseSummary on dia equals saida.dia into saidaAgrupado
                                      from saida in saidaAgrupado.DefaultIfEmpty()
                                      select new
                                      {
                                          day = dia,
                                          entrada = entrada == null ? 0 : entrada.entrada,
                                          saida = saida == null ? 0 : saida.saida,
                                      };
            //Transação Recente
            ViewBag.RecentTransactions = await _context.Transactions
                .Include(i => i.Categoria)
                .OrderByDescending(j => j.Data)
                .Take(5)
                .ToListAsync();


            return View();

        }
    }
}

public class SplineChartData
{
    public string dia;
    public int entrada;
    public int saida;

}

