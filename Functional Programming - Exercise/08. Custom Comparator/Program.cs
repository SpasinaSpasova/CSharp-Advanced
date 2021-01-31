using System;
using System.Linq;

namespace _08._Custom_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Array.Sort(nums, (a, b) =>
             {
                 if (a % 2 != 0 && b % 2 == 0)
                 {
                     return 1;
                 }
                 else if (a % 2 == 0 && b % 2 != 0)
                 {
                     return -1;

                 }
                 int temp = a.CompareTo(b);
                 return temp;



             });
            Console.WriteLine(string.Join(" ",nums));
        }
    }
}
