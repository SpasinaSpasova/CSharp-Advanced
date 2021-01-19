using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPumps = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>();

            for (int i = 0; i < numOfPumps; i++)
            {
                string input = Console.ReadLine()+$" {i}";
              
                queue.Enqueue(input);
            }

            int totalFuel = 0;
            for (int i = 0; i < numOfPumps; i++)
            {
                string[] tokens = queue.Peek().Split();
                int petrol = int.Parse(tokens[0]);
                int distance = int.Parse(tokens[1]);
                totalFuel += petrol;

                if (totalFuel < distance)
                {
                    totalFuel = 0;
                    i = -1;
                }
                else
                {
                    totalFuel -= distance;

                }
                string curr = queue.Dequeue();
                queue.Enqueue(curr);

            }
            var first = queue.Dequeue().Split().ToArray();

            Console.WriteLine(first[2]);
        }
    }
}
