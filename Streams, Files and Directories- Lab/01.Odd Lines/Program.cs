using System;
using System.IO;

namespace _01.Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("../../../Input.txt");
            using (reader)
            {
                int count = 0;
                string line = reader.ReadLine();

                using (StreamWriter writer = new StreamWriter("../../../output.txt"))
                {

                    while (line!= null)
                    {
                      
                        if (count % 2 != 0)
                        {
                            writer.WriteLine(line);
                        }
                        count++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
