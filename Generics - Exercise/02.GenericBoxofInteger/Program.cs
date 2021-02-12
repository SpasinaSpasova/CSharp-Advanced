using System;

namespace _02.GenericBoxofInteger
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int command = int.Parse(Console.ReadLine());
                Box<int> current = new Box<int>(command);
                Console.WriteLine(current);
            }
        }
    }
}
