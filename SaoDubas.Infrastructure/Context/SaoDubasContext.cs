using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SaoDubas.Domain.Models;
using SaoDubas.Infrastructure.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaoDubas.Infrastructure.Context
{
    public class SaoDubasContext : DbContext
    {
        public readonly string _connectionString = string.Empty;

        public SaoDubasContext(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("SAODUBAS");
        }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Aqui deve se adicionar todas as ApplyConfiguration
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
        }
    }
}
