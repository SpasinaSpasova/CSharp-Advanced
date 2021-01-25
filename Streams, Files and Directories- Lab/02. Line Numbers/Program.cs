using System;
using System.IO;

namespace _02._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("../../../Input.txt");
            using (reader)
            {
                int count = 1;
                string line = reader.ReadLine();

                using (StreamWriter writer = new StreamWriter("../../../output.txt"))
                {

                    while (line != null)
                    {

                            writer.WriteLine($"{count}. {line}");
                        
                        count++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
