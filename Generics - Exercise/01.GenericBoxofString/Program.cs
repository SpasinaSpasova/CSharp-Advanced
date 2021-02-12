using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.GenericBoxofString
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                Box<string> current = new Box<string>(command);
                Console.WriteLine(current);
            }
        }
    }
}
