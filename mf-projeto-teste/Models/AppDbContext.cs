using Gerenciador_de_consumo_de_veiculos.Models;
using Microsoft.EntityFrameworkCore;

namespace mf_projeto_teste.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Veiculo> Veiculos { get; set; }

        public DbSet<Consumo> Consumos { get; set; }
    }
}
