using Microsoft.EntityFrameworkCore;

namespace StoreApp.Models;

public class RepositoryContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Product>().HasData(
            new Product() { ProductId = 1, ProductName = "Monitor", Price = 19_000 },
            new Product() { ProductId = 2, ProductName = "Adjustable Desk", Price = 11_000 },
            new Product() { ProductId = 3, ProductName = "Gaming Chair", Price = 7_999 },
            new Product() { ProductId = 4, ProductName = "Keyboard and Mouse Set", Price = 2_400 },
            new Product() { ProductId = 5, ProductName = "Case", Price = 6_100 }
        );
    }
}