using System;
using System.Threading.Tasks;

namespace LAB_4
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var context = new AppDbContext();

            var author1 = new Author { Name = "George Orwell" };
            var author2 = new Author { Name = "Jane Austen" };
            var author3 = new Author { Name = "Mark Twain" };
            var author4 = new Author { Name = "J.K. Rowling" };

            await context.Authors.AddRangeAsync(author1, author2, author3, author4);

            var book1 = new Book { Title = "1984", Price = 299, Author = author1 };
            var book2 = new Book { Title = "Animal Farm", Price = 199, Author = author1 };
            var book3 = new Book { Title = "Pride and Prejudice", Price = 349, Author = author2 };
            var book4 = new Book { Title = "Emma", Price = 289, Author = author2 };
            var book5 = new Book { Title = "Adventures of Huckleberry Finn", Price = 399, Author = author3 };
            var book6 = new Book { Title = "Harry Potter and the Sorcerer's Stone", Price = 499, Author = author4 };

            await context.Books.AddRangeAsync(book1, book2, book3, book4, book5, book6);

            await context.SaveChangesAsync();

            Console.WriteLine("Initial book and author data inserted successfully!");
        }
    }
}