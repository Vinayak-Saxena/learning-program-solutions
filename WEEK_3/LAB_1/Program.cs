using LAB_1.Models;
using LAB_1.Data;
using var context = new BookstoreContext();

var fiction = new Genre { Name = "Fiction" };
context.Genres.Add(fiction);

var book1 = new Book { Title = "The Alchemist", Price = 450, Genre = fiction };
context.Books.Add(book1);

context.SaveChanges();

Console.WriteLine("Book inserted into the database.");

var allBooks = context.Books.ToList();
Console.WriteLine("\n Books in Inventory:");
foreach (var b in allBooks)
{
    Console.WriteLine($"- {b.Title} (₹{b.Price})");
}