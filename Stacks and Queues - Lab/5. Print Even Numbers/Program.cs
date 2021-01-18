using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _5._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> allNums = new Queue<int>(numbers);

            int count = allNums.Count;
            for (int i = 0; i < count; i++)
            
            {

                if (allNums.Peek() % 2 == 0)
                {
                   
                    allNums.Enqueue(allNums.Dequeue());
                }
                else
                {
                    allNums.Dequeue();
                }
            }
            Console.WriteLine(string.Join(", ",allNums));
        }
    }
}
