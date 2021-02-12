using System;
using System.Linq;

namespace _07.Tuple
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] commands = Console.ReadLine().Split(" ");

            string name = commands[0] + " " + commands[1];
            MyTuple<string, string> first = new MyTuple<string, string>(name,commands[2]);
            Console.WriteLine(first);

            string[] commands2 = Console.ReadLine().Split(" ");

            MyTuple<string, int> second = new MyTuple<string, int>(commands2[0], int.Parse(commands2[1]));
            Console.WriteLine(second);

            string[] commands3 = Console.ReadLine().Split(" ");

            MyTuple<int, double> third = new MyTuple<int, double>(int.Parse(commands3[0]), double.Parse(commands3[1]));
            Console.WriteLine(third);
        }
    }
}
