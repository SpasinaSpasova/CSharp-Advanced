using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {

            Func<string, bool> checker = str => str[0].ToString() == str[0].ToString().ToUpper();

            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(checker)
                .ToArray();

            foreach (string item in input)
            {
                Console.WriteLine(item);
            }


        }
    }
}
