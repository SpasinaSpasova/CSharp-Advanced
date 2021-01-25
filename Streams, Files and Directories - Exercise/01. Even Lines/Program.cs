using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01._Even_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../text.txt"))
            {
                string line = reader.ReadLine();
                int count = 0;
                while (line != null)
                {
                    if (count % 2 == 0)
                    {
                        Regex pattern = new Regex("[-,.!?]");
                        line=pattern.Replace(line,"@");
                        string[] reversed = line.Split().Reverse().ToArray();
                        Console.WriteLine(string.Join(" ",reversed));
                    }
                    count++;

                    line = reader.ReadLine();
                }




            }
        }
    }
}
