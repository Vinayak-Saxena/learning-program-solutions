using System;

class ExpenseForecast
{
    static void Main()
    {
        Console.Write("Enter number of past months: ");
        int n = int.Parse(Console.ReadLine()!);

        double[] expenses = new double[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter expense for month {i + 1} (in ₹): ");
            expenses[i] = double.Parse(Console.ReadLine()!);
        }

        double[] growth = new double[n - 1];
        for (int i = 1; i < n; i++)
            growth[i - 1] = (expenses[i] - expenses[i - 1]) / expenses[i - 1];

        double avgGrowth = 0;
        foreach (double g in growth)
            avgGrowth += g;
        avgGrowth /= growth.Length;

        double forecast = expenses[n - 1] * (1 + avgGrowth);

        Console.WriteLine($"\nBased on an average growth of {avgGrowth * 100:F2}%");
        Console.WriteLine($"Forecasted expense for next month = ₹{forecast:F2}");
    }
}
