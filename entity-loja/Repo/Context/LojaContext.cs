using entity_loja.Repo.Entities;
using Microsoft.EntityFrameworkCore;

namespace entity_loja.Repo.Context
{
    public class LojaContext : DbContext{
         public LojaContext()
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=LojaDB;Trusted_Connection=true;");
        }
        
        
        public DbSet<Produto> Produtos { get; set; }
    }
}