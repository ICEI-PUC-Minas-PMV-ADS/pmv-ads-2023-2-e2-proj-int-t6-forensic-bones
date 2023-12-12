using Microsoft.EntityFrameworkCore;

namespace ForensicBones100.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Relatorio> Relatorios { get; set; }
        public DbSet<InventarioEsqueleto> InventariosEsqueleto { get; set; }
        public DbSet<InventarioCranio> InventariosCranio { get; set; }
        public DbSet<MarcadoresCranio> MarcadoresCranios { get; set; }

        // Configurações adicionais do modelo, se necessário, podem ser feitas aqui
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Relatorio>()
        .HasMany(r => r.InventariosEsqueleto)
        .WithOne(i => i.Relatorio)
        .HasForeignKey(i => i.RelatorioId);
        }
    }
}