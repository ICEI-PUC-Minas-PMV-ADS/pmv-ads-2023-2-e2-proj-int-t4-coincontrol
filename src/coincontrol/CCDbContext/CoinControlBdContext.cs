using coincontrol.Models.Usuario;
using Microsoft.EntityFrameworkCore;
using coincontrol.Models.Carteira;
using coincontrol.Models.Meta;
using coincontrol.Models;

namespace coincontrol.CCDbContext
{
    public class CoinControlBdContext : DbContext
    {
        public CoinControlBdContext(DbContextOptions<CoinControlBdContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<coincontrol.Models.Carteira.Carteira> Carteira { get; set; }

        public DbSet<Meta> Metas { get; set; }

        public DbSet<Transaction> Transactions { get; set; }
        
        public DbSet<Category> Categories { get; set; }

    }
}
