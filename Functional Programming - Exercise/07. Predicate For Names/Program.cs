using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int length= int.Parse(Console.ReadLine());

            List<string> words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();


            Func<string, bool> predicate = i => i.Length <= length;

            words = words.Where(predicate).ToList();
            foreach (string name in words)
            {
                Console.WriteLine(name);
            }
          
        }
    }
}
