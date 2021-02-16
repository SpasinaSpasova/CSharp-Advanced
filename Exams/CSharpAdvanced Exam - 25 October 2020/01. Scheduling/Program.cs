using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> tasks = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());

            Queue<int> threads = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());

            int taskToKill = int.Parse(Console.ReadLine());

            while (true)
            {
                int task = tasks.Peek();
                int thread = threads.Peek();
                if (task == taskToKill)
                {
                    Console.WriteLine($"Thread with value {thread} killed task {taskToKill}");
                    Console.WriteLine(string.Join(" ", threads));

                    break;
                }
                if (thread >= task)
                {

                    tasks.Pop();
                    threads.Dequeue();
                }
                else
                {

                    threads.Dequeue();
                }
            }
        }
    }
}
