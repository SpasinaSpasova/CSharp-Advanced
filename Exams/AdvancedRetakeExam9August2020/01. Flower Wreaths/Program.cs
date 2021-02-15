using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Flower_Wreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> lilies = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

            Queue<int> roses = new Queue<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            int wreaths = 0;
            int sumFlowers = 0;
            while (lilies.Count > 0 && roses.Count > 0)
            {
                int lili = lilies.Pop();
                int rose = roses.Dequeue();
                int sum = lili + rose;

                if (sum == 15)
                {
                    wreaths++;
                }
                else if (sum < 15)
                {
                    sumFlowers += sum;
                }
                else if (sum > 15)
                {
                    while (sum > 15)
                    {
                        sum -= 2;
                        if (sum == 15)
                        {
                            wreaths++;
                            break;
                        }
                        else if (sum < 15)
                        {
                            sumFlowers += sum;
                            break;
                        }
                    }
                }



            }
            if (sumFlowers >= 15)
            {
                wreaths += sumFlowers /15;

            }
            if (wreaths >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreaths} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5 - wreaths} wreaths more!");
            }
        }
    }
}
