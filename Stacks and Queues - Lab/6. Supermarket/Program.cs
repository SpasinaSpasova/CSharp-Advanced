using System;
using System.Collections;
using System.Collections.Generic;

namespace _6._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Queue<string> clients = new Queue<string>();

            while (name!="End")
            {
                if (name=="Paid")
                {
                    while (clients.Count>0)
                    {
                        Console.WriteLine( clients.Dequeue());
                    }
                }
                else
                {
                    clients.Enqueue(name);
                }
                name = Console.ReadLine();
            }
            Console.WriteLine($"{clients.Count} people remaining.");
        }
    }
}
