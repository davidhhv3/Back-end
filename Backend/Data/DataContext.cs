using Microsoft.EntityFrameworkCore;

namespace Backend.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Models.Products> Product { get; set; }

        public DbSet<Models.Status> Status { get; set; }

    }
}
