using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _7._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] gamers = Console.ReadLine().Split().ToArray();

            Queue<string> queue = new Queue<string>(gamers);
            int n = int.Parse(Console.ReadLine());
            int toss = 0;
            while (queue.Count>1)
            {
                toss++;
                if (toss==n)
                {
                   string removeKid= queue.Dequeue();
                    Console.WriteLine($"Removed {removeKid}");
                    toss = 0;
                }
                else
                {
                    string kid = queue.Dequeue();
                    queue.Enqueue(kid);

                }
            }
            Console.WriteLine("Last is "+queue.Dequeue());
        }
    }
}
