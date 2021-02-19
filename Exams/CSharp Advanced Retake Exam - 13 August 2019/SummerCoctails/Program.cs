using System;
using System.Collections.Generic;
using System.Linq;

namespace SummerCoctails
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> ingredients = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());

            Stack<int> freshness = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());

            int mimosa = 0;
            int daiquiri = 0;
            int sunshine = 0;
            int mojito = 0;

            while (ingredients.Count>0&&freshness.Count>0)
            {
                int ingredient = ingredients.Peek();
                int fresh = freshness.Peek();

                if (ingredient==0)
                {
                    ingredients.Dequeue();
                    continue;
                }
                int coctail = ingredient * fresh;

                if (coctail==150)
                {
                    mimosa++;
                    ingredients.Dequeue();
                    freshness.Pop();
                }
                else if (coctail==250)
                {
                    daiquiri++;
                    ingredients.Dequeue();
                    freshness.Pop();
                }
                else if (coctail==300)
                {
                    sunshine++;
                    ingredients.Dequeue();
                    freshness.Pop();
                }
                else if (coctail==400)
                {
                    mojito++;
                    ingredients.Dequeue();
                    freshness.Pop();
                }
                else
                {
                    freshness.Pop();
                    int temp = ingredients.Dequeue() + 5;
                    ingredients.Enqueue(temp);
                }
                
            }
            if (daiquiri > 0 && mimosa > 0 && mojito > 0 && sunshine > 0)
            {
                Console.WriteLine("It's party time! The cocktails are ready!");
            }
            else
            {
                Console.WriteLine("What a pity! You didn't manage to prepare all cocktails.");
            }
            if (ingredients.Count > 0)
            {
                Console.WriteLine($"Ingredients left: {ingredients.Sum()}");
            }

            if (daiquiri > 0)
            {
                Console.WriteLine($" # Daiquiri --> {daiquiri}");
            }
            if (mimosa > 0)
            {
                Console.WriteLine($" # Mimosa --> {mimosa}");
            }
            if (mojito > 0)
            {
                Console.WriteLine($" # Mojito --> {mojito}");
            }
            if (sunshine > 0)
            {
                Console.WriteLine($" # Sunshine --> {sunshine}");
            }
        }
    }
}
