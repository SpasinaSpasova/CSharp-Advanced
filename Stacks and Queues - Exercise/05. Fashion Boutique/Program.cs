using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());
            int theWorkCpacity = rackCapacity;
            Stack<int> stack = new Stack<int>(clothes);
            int sum = 0;
            int racks = 1;
            while (stack.Count > 0)
            {
                int curr = stack.Peek();
               
                if (sum + curr <= rackCapacity)
                {
                    sum += curr;
                    theWorkCpacity -= curr;
                    

                }
                else if (sum + curr > rackCapacity)
                {
                    racks++;
                    
                    theWorkCpacity = rackCapacity-curr;
                    sum = curr;
                    

                }
                stack.Pop();

            }
            Console.WriteLine(racks);
        }
    }
}
