using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LAB_5
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var db = new RetailDbContext();

            var allItems = await db.Items.ToListAsync();
            Console.WriteLine("Complete Inventory:");
            foreach (var item in allItems)
            {
                Console.WriteLine($"{item.Name} — ₹{item.Price}");
            }

            var selected = await db.Items.FindAsync(1);
            Console.WriteLine($"Item with ID=1: {selected?.Name ?? "Not Found"}");

            var costly = await db.Items.FirstOrDefaultAsync(i => i.Price >= 50000);
            Console.WriteLine($"First Premium Item: {costly?.Name ?? "None"}");
        }
    }
}