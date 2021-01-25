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
            string[] readerWords = File.ReadAllLines("../../../words.txt");
            string[] readerText = File.ReadAllLines("../../../text.txt");


            Dictionary<string, int> theContains = new Dictionary<string, int>();
            List<string> result = new List<string>();

            for (int i = 0; i < readerWords.Length; i++)
            {
                string currentWord = readerWords[i];

                for (int j = 0; j < readerText.Length; j++)
                {
                    string currentLine = readerText[j];

                    if (currentLine.ToLower().Contains(currentWord))
                    {
                        if (!theContains.ContainsKey(currentWord))
                        {
                            theContains.Add(currentWord, 0);
                        }
                        theContains[currentWord]++;

                    }
                }
            }

            foreach (var item in theContains.OrderByDescending(x => x.Value))
            {
                result.Add($"{item.Key} - {item.Value}");
               
            }
            for (int i = 0; i < result.Count; i++)
            {
                File.WriteAllLines("../../../actualResults.txt", result);
            }
        }
    }
}
