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


        public StockDbContext(DbContextOptions<StockDbContext> options ) : base(options )  
        {

        }
    }
}
