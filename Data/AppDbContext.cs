using hnl.veiculos.com.br.Entities;
using Microsoft.EntityFrameworkCore;

namespace hnl.veiculos.com.br.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){ }

        public DbSet<Marca> Marca { get; set; }
        public DbSet<Modelo> Modelo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Marca>().HasKey(p => p.ID);
            modelBuilder.Entity<Modelo>().HasKey(p => p.ID);
        }
    }
}