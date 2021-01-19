using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());

            int[] clientsOrder = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(clientsOrder);

            Console.WriteLine(queue.Max());

            while (queue.Count>0)
            {
                int client = queue.Peek();

                if (client <= foodQuantity)
                {
                    foodQuantity -= client;
                    queue.Dequeue();
                }
                else
                {
                    Console.WriteLine("Orders left: "+ string.Join(" ",queue));
                    break;
                }
            }
            if (queue.Count==0)
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
