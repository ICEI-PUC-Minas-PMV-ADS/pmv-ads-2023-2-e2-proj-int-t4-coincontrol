using coincontrol.Models.Usuario;
using Microsoft.EntityFrameworkCore;

namespace coincontrol.CCDbContext
{
    public class CoinControlBdContext : DbContext
    {
        public CoinControlBdContext(DbContextOptions<CoinControlBdContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Models.Carteira.Carteira> Carteiras { get; set; }
    }
}
