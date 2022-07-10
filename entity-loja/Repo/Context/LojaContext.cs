using System;
using entity_loja.Entities;
using Microsoft.EntityFrameworkCore;

namespace entity_loja.Repo.Context
{
    public class LojaContext : DbContext
    {
        public LojaContext()
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection =
            @"server=localhost;
            port=3306;
            database=database-entity;
            user=user-entity;
            password=123entity";
            var version = new MySqlServerVersion(new Version(10, 6, 0));
            optionsBuilder.UseMySql(connection, version);

            optionsBuilder.LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, Microsoft.Extensions.Logging.LogLevel.Information);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
            .Entity<Endereco>()
            .ToTable("Enderecos");

            modelBuilder
            .Entity<Endereco>()
            .Property<int>("ClienteId");


            modelBuilder
            .Entity<Endereco>()
            .HasKey("ClienteId");
        }


        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Promocao> Promocoes { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

    }
}