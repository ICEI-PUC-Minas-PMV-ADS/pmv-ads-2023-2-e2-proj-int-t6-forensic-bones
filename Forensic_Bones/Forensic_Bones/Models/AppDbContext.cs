using Microsoft.EntityFrameworkCore;

namespace Forensic_Bones.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        
        public DbSet<FotoEsqueleto> FotografiasEsqueleto { get; set; }
        public DbSet<FotoAchado> FotografiasAchados { get; set; }
        public DbSet<InventEsqueleto> InventarioEsqueleto { get; set; }

        public DbSet<InventCranio> InventarioCranio { get; set; }

        public DbSet<MarcadorCranio> MarcadoresCranio { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
    }
    
}

