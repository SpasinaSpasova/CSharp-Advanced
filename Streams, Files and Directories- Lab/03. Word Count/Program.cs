using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03._Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader readerWords = new StreamReader("../../../words.txt");
            StreamReader readerText = new StreamReader("../../../text.txt");
            StreamWriter writer = new StreamWriter("../../../output.txt");

            Dictionary<string, int> theContains = new Dictionary<string, int>();

            using (readerWords)
            {

                string[] words = readerWords.ReadLine().ToLower().Split().ToArray();

                using (readerText)
                {
                    string line = readerText.ReadLine().ToLower();


                    while (line != null)
                    {

                        for (int i = 0; i < words.Length; i++)
                        {

                            if (line.ToLower().Contains(words[i]))
                            {
                                if (!theContains.ContainsKey(words[i]))
                                {
                                    theContains.Add(words[i], 0);
                                }
                                theContains[words[i]]++;

                            }


                        }
                        line = readerText.ReadLine();
                    }

                }
            }
            using (writer)
            {
                foreach (var item in theContains.OrderByDescending(x=>x.Value))
                {
                    writer.WriteLine($"{item.Key} - {item.Value}");

                }
            }
        }
    }
}
