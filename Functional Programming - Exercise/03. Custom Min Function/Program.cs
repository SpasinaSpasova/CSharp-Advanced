using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();


            Func<List<int>, int> minNum = n =>
            {

                int min = int.MaxValue;
                foreach (int numbers in nums)
                {
                    if (numbers < min)
                    {
                        min = numbers;
                    }
                }
                return min;
            };
            int minimal = minNum(nums);

            Action<int> print = n => Console.WriteLine(n);
            print(minimal);
        }
    }
}
