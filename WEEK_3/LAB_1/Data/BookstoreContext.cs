using Microsoft.EntityFrameworkCore;
using LAB_1.Models;

namespace LAB_1.Data;

public class BookstoreContext : DbContext
{
    public DbSet<Book> Books => Set<Book>();
    public DbSet<Genre> Genres => Set<Genre>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=BookstoreDb;Trusted_Connection=True;");
    }
}