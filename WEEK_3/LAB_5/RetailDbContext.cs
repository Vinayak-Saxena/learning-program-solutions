using Microsoft.EntityFrameworkCore;

namespace LAB_5
{
    public class RetailDbContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Group> Groups { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=RetailLab5;Trusted_Connection=True;");
        }
    }
}