using Microsoft.EntityFrameworkCore;
using LAB_2.Models;

namespace LAB_2.Data;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products => Set<Product>();
    public DbSet<Category> Categories => Set<Category>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=RetailStore;Trusted_Connection=True;");
    }
}