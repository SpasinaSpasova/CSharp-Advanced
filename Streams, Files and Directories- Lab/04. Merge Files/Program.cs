using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _04._Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> merge = new List<int>();

            StreamReader first = new StreamReader("../../../FileOne.txt");
            StreamReader second = new StreamReader("../../../FileTwo.txt");
            StreamWriter writer = new StreamWriter("../../../merged.txt");

            using (first)
            {

              
                using (second)
                {
                    string line = first.ReadLine();
                    string line2 = second.ReadLine();


                    while (line != null&& line2!=null)
                    {

                        merge.Add(int.Parse(line));
                        merge.Add(int.Parse(line2));
                        line = first.ReadLine();
                        line2 = second.ReadLine();

                    }

                }
            }
            using (writer)
            {
                foreach (var item in merge.OrderBy(x => x))
                {
                    writer.WriteLine($"{item}");

                }
            }
        }
    }
}
