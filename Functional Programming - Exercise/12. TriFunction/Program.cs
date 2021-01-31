using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int len = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine().Split().ToList();

            Func<string,int,bool> Checker= (name,chValue)=>name.ToCharArray().Select(currCh => (int)currCh).Sum() >= chValue;

            Func<List<string>, int, Func<string, int, bool>, string> NameIsValid = (array, currNum, func) => array
                .FirstOrDefault(name => func(name, currNum));

            string result = NameIsValid(names, len, Checker);

            Console.WriteLine(result);
        }
    }
}
