using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cupsCapacity = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] filledBottles = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //пълни бутилки с вода

            Stack<int> stack = new Stack<int>(filledBottles);//бутилки
            Queue<int> queue = new Queue<int>(cupsCapacity);//чашки

            int wastedLiitters = 0;

            while (queue.Count > 0)
            {
                int bottle = stack.Peek();
                int cup = queue.Peek();
                if (bottle == cup)
                {
                    queue.Dequeue();
                    stack.Pop();
                }
                else if (bottle > cup)
                {
                    queue.Dequeue();
                    wastedLiitters += bottle - cup;
                    stack.Pop();
                }
                else if (bottle < cup)
                {
                    stack.Pop();
                    cup -= bottle;

                    while (cup > 0)
                    {
                        bottle = stack.Pop();
                        cup -= bottle;

                    }

                    if (cup <= 0 && bottle > cup)
                    {
                        queue.Dequeue();
                        wastedLiitters += (cup * (-1));//???

                    }


                }
                if (stack.Count == 0)
                {
                    break;
                }
            }
            if (queue.Count == 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", stack)}");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine($"Cups: {string.Join(" ", queue)}");

            }
            Console.WriteLine($"Wasted litters of water: {wastedLiitters}");
        }
    }
}
