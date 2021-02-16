using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Bombs
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue<int> effects = new Queue<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());

            Stack<int> casings = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());

            int datura = 0;
            int cherry = 0;
            int smoke = 0;
            bool flag = false;

            while (effects.Count > 0 && casings.Count > 0)
            {
                if (datura >= 3 && cherry >= 3 && smoke >= 3)
                {
                    flag = true;
                    break;
                }

                int effect = effects.Peek();
                int casing = casings.Peek();
                int sum = effect + casing;

                if (sum == 40)
                {
                    datura++;
                    effects.Dequeue();
                    casings.Pop();
                }
                else if (sum == 60)
                {
                    cherry++;
                    effects.Dequeue();
                    casings.Pop();
                }
                else if (sum == 120)
                {
                    smoke++;
                    effects.Dequeue();
                    casings.Pop();
                }
                else
                {
                    while (true)
                    {
                        sum -= 5;

                        if (sum == 40)
                        {
                            datura++;
                            effects.Dequeue();
                            casings.Pop();
                            break;
                        }
                        else if (sum == 60)
                        {
                            cherry++;
                            effects.Dequeue();
                            casings.Pop();
                            break;
                        }
                        else if (sum == 120)
                        {
                            smoke++;
                            effects.Dequeue();
                            casings.Pop();
                            break;
                        }
                    }
                }
            }

            if (flag)

            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }
            if (effects.Count == 0)
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", effects)}");

            }

            if (casings.Count == 0)
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", casings)}");

            }

            Console.WriteLine($"Cherry Bombs: {cherry}");
            Console.WriteLine($"Datura Bombs: {datura}");
            Console.WriteLine($"Smoke Decoy Bombs: {smoke}");

        }
    }
}
