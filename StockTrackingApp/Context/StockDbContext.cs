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
                new Category { Id = 2, Name = "Male" },
                new Category { Id = 3, Name = "Kids" }
                );


            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, CategoryID = 1, ProductName = "T-shirt", Brand = "Mango", Price = 150, Quantity = 300 },
                new Product { Id = 2, CategoryID = 2, ProductName = "T-shirt", Brand = "Mango", Price = 150, Quantity = 300 },
                 new Product { Id = 3, CategoryID = 2, ProductName = "Jeans", Brand = "Mango", Price = 750, Quantity = 150 },
                 new Product { Id = 4, CategoryID = 1, ProductName = "Jeans", Brand = "Mango", Price = 750, Quantity = 250 },
                 new Product { Id = 5, CategoryID = 3, ProductName = "Dress", Brand = "Mango", Price = 250, Quantity = 50 },
                 new Product { Id = 6, CategoryID = 1, ProductName = "Dress", Brand = "Mango", Price = 1000, Quantity = 100 }
                );


            modelBuilder.Entity<Client>().HasData(

                new Client { Id = 1, Name = "Karen", Surname="Benes" },
                new Client { Id = 2, Name = "Fatma", Surname = "Aydoğ" },
                new Client { Id = 3, Name = "Aysecik", Surname = "Meral" },
                new Client { Id = 4, Name = "Doruk", Surname = "Erdemir" }
                );
        }
    }
}
