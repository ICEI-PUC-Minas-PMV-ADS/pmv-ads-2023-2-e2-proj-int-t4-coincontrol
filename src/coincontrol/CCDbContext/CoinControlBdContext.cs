using coincontrol.Models.Transaction;
using coincontrol.Models.Usuario;
using Microsoft.EntityFrameworkCore;
using coincontrol.Models.TransacoesA;
using coincontrol.Models.Carteira; 

namespace coincontrol.CCDbContext
{
    public class CoinControlBdContext : DbContext
    {
        public CoinControlBdContext(DbContextOptions<CoinControlBdContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Expense> Expenses { get; set; }

        public DbSet<coincontrol.Models.Transaction.Income> Income { get; set; }

        public DbSet<Models.TransacoesA.TransacoesA> TransacoesA { get; set; }

        public DbSet<coincontrol.Models.Carteira.Carteiras> Carteiras { get; set; }

    }
}
