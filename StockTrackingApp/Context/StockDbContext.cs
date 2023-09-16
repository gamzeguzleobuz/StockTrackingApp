using Microsoft.EntityFrameworkCore;
using StockTrackingApp.Data;

namespace StockTrackingApp.Context
{
    public class StockDbContext : DbContext
    {
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<Product> Products => Set<Product>();
        public DbSet<Client> Clients => Set<Client>();
        public DbSet<Sale> Sales => Set<Sale>();


        public StockDbContext(DbContextOptions<StockDbContext> options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(

                new Category { Id = 1, Name = "Female" },
        new Category { Id = 2, Name = "Male" }
                );


            modelBuilder.Entity<Product>().HasData(
          new Product { Id = 1, CategoryID = 1, ProductName = "T-shirt", Price = 150 },
          new Product { Id = 2, CategoryID = 2, ProductName = "T-shirt", Price = 150 }
      );
        }
    }
}
