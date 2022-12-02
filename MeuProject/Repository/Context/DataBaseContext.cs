using MeuProject.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace MeuProject.Repository.Context
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Animal> Animal { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
                optionsBuilder.UseSqlServer(config.GetConnectionString("MeuProjectConnection"));
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}