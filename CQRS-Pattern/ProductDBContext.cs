using Microsoft.EntityFrameworkCore;

namespace CQRS_Pattern
{
    public class ProductDBContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlite("DataSource=products.db;Cache=Shared");
    }
}
