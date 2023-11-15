using coincontrol.Models.Usuario;
using Microsoft.EntityFrameworkCore;
using coincontrol.Models.TransacoesA;
using coincontrol.Models.Carteira;
using coincontrol.Models.Meta;
using coincontrol.Models.Categoria;
using coincontrol.Models;

namespace coincontrol.CCDbContext
{
    public class CoinControlBdContext : DbContext
    {
        public CoinControlBdContext(DbContextOptions<CoinControlBdContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Models.TransacoesA.TransacoesA> TransacoesA { get; set; }

        public DbSet<coincontrol.Models.Carteira.Carteiras> Carteiras { get; set; }

        public DbSet<Meta> Metas { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Transaction> Transactions { get; set; }
        
        public DbSet<Category> Categories { get; set; }

    }
}
