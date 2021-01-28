using System;
using System.Linq;

namespace _04._Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double, double> vat = x => x * 1.20;
            double[] prices = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(vat)
                 .ToArray();
            foreach (double item in prices)
            {
                Console.WriteLine($"{item:f2}");
            }
        }
    }
}
