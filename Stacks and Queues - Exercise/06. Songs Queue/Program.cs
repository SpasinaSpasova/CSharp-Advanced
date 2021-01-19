using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ").ToArray();

            Queue<string> queue = new Queue<string>(songs);

            while (queue.Count > 0)
            {
                string command = Console.ReadLine();

                if (command.Contains("Play"))
                {
                    if (queue.Count>0)
                    {
                        queue.Dequeue();
                    }
                   
                }
                else if (command.Contains("Add"))
                {
                    string song = command.Substring(4);

                    if (queue.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        queue.Enqueue(song);
                    }
                }
                else if (command.Contains("Show"))
                {
                    Console.WriteLine(string.Join(", ",queue));
                }



            }
            Console.WriteLine("No more songs!");
        }
    }
}
