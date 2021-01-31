using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            Dictionary<string, List<int>> allCommand = new Dictionary<string, List<int>>()
            {
                { "add",new List<int>()},
                { "multiply",new List<int>()},
                { "subtract",new List<int>()},
                { "print",new List<int>()},
                { "end",new List<int>()},
            };

            Func<int, int> func = num => num;

            while (true)
            {
                string command = Console.ReadLine();


                if (command == "add" && allCommand.ContainsKey("add"))
                {
                    func = n => n + 1;
                    numbers = numbers.Select(func).ToList();
                }
                else if (command == "multiply" && allCommand.ContainsKey("multiply"))
                {
                    func = n => n * 2;
                    numbers = numbers.Select(func).ToList();
                }
                else if (command == "subtract" && allCommand.ContainsKey("subtract"))
                {
                    func = n => n - 1;
                    numbers = numbers.Select(func).ToList();
                }
                else if (command == "print" && allCommand.ContainsKey("print"))
                {
                    Console.WriteLine(string.Join(" ", numbers));
                }
                else if (command == "end" && allCommand.ContainsKey("end"))
                {
                    break;
                }
            }
        }

    }
}



