using System;
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
            var connection = "server=localhost;port=3306;database=database-entity;user=user-entity;password=123entity";
            var version = new MySqlServerVersion(new Version(10,6,0)); 
            optionsBuilder.UseMySql(connection, version );
        }
        
        
        public DbSet<Produto> Produtos { get; set; }
    }
}