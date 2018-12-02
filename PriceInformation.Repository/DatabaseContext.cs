using Microsoft.EntityFrameworkCore;
using PriceInformation.Repository.Entities;
using System.Configuration;

namespace PriceInformation.Repository
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Product> Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(ConfigurationManager.ConnectionStrings["PriceInformationConnectionString"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>(en =>
            {
                en.HasKey(e => e.Id);
            });
        }
    }
}
