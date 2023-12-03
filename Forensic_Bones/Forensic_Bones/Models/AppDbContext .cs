using Microsoft.EntityFrameworkCore;
using Forensic_Bones.Models;

namespace Forensic_Bones.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Relatorio> Relatorios { get; set; }
        public DbSet<InventarioEsqueleto> InventariosEsqueleto { get; set; }
        public DbSet<InventarioCranio> InventarioCranio { get; set; }
        public DbSet<MarcadoresCranio> MarcadoresCranio { get; set; }

        // Configurações adicionais do modelo, se necessário, podem ser feitas aqui
       
    }
}