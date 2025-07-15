using LAB_2.Data;

using (var context = new AppDbContext())
{
    var electronics = new Category { Name = "Electronics" };
    var grocery = new Category { Name = "Grocery" };

    context.Categories.AddRange(electronics, grocery);

    var product1 = new Product { Name = "Laptop", Price = 45000, Category = electronics };
    var product2 = new Product { Name = "Apple", Price = 120, Category = grocery };

    context.Products.AddRange(product1, product2);
    context.SaveChanges();

    var products = context.Products.Include(p => p.Category).ToList();
    foreach (var product in products)
    {
        Console.WriteLine($"{product.Name} - ₹{product.Price} ({product.Category?.Name})");
    }
}

