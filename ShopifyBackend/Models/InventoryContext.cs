using Microsoft.EntityFrameworkCore;

namespace ShopifyBackend.Models
{
    public class InventoryContext : DbContext
    {
        public InventoryContext() { }

        public InventoryContext(DbContextOptions<InventoryContext> options) : base(options) 
        { 

        }

        public DbSet<Inventory> Inventories { get; set; }

        public DbSet<Location> Locations { get; set; }
    }
}
