using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var dateOne = Console.ReadLine();

            var dateTwo = Console.ReadLine();

            DateModifier.GetDiff(dateOne, dateTwo);
            Console.WriteLine(DateModifier.GetDiff(dateOne, dateTwo));

        }
    }
}
