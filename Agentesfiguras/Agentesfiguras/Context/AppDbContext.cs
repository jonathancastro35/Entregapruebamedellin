using Microsoft.EntityFrameworkCore;
using Agentesfiguras.Modelofigura;

namespace Agentesfiguras.Context
{

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Funcionalidades> Funcionalidades { get; set; }

public DbSet<Agentesfiguras.Modelofigura.Funcionalidaddos> Funcionalidaddos { get; set; } = default!;

public DbSet<Agentesfiguras.Modelofigura.Funcionalidaduno> Funcionalidaduno { get; set; } = default!;


    }
}





