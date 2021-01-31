using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Reverse().ToList();

            int n = int.Parse(Console.ReadLine());

            Func<int, bool> predicate = i => i % n != 0;

            numbers = numbers.Where(predicate).ToList();
            Action<List<int>> print = num => Console.WriteLine(string.Join(" ", num));
            print(numbers);

        }
        //static List<int> MyWhere(List<int> myList, Func<int, bool> myPredicate)
        //{
        //    List<int> newList = new List<int>();

        //    for (int i = 0; i < myList.Count; i++)
        //    {
        //        if (myPredicate(myList[i]))
        //        {
        //            myPredicate(i);
        //            newList.Add(myList[i]);
        //        }
        //    }
        //    return newList;
        //}
    }
}
   


        
        


