using Microsoft.EntityFrameworkCore;
using _19_Atividade.Models;

namespace _19_Atividade.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {
            
        }
        public DbSet<Veiculos> Veiculo { get; set; }

    }
}
