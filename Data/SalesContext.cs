using Microsoft.EntityFrameworkCore;

namespace MyWebApp.Data
{
    public class SalesContext : DbContext
    {
        public SalesContext(DbContextOptions<SalesContext> options) : base(options)
        {
        }

        public DbSet<Product>? Products { get; set; }
    }
}