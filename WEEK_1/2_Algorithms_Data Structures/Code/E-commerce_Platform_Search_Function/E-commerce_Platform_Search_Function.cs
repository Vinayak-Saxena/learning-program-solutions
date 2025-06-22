using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] products = {
            "Samsung Galaxy S24",
            "Apple iPhone 15",
            "Sony Headphones",
            "Asus Laptop",
            "Acer Monitor",
            "Samsung Smart TV",
            "Apple Watch",
            "HP Pavilion Laptop",
            "Realme Buds",
            "Redmi Note 13"
        };

        Console.Write("Enter product name prefix to search: ");
        string prefix = Console.ReadLine()!.ToLower();

        List<string> matches = new();

        
        foreach (var product in products)
        {
            if (product.ToLower().StartsWith(prefix))
                matches.Add(product);
        }

       
        BubbleSort(matches);

       
        Console.WriteLine("\nTop matches:");
        for (int i = 0; i < Math.Min(3, matches.Count); i++)
            Console.WriteLine(matches[i]);

        if (matches.Count == 0)
            Console.WriteLine("No matches found.");
    }

    static void BubbleSort(List<string> list)
    {
        int n = list.Count;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (string.Compare(list[j], list[j + 1], StringComparison.OrdinalIgnoreCase) > 0)
                {
                    var temp = list[j];
                    list[j] = list[j + 1];
                    list[j + 1] = temp;
                }
            }
        }
    }
}
