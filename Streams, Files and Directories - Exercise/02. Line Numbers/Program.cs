using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _02._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] allLines = File.ReadAllLines("../../../text.txt");

            List<string> newLines = new List<string>();

            

            for (int i = 0; i < allLines.Length; i++)
            {
                string currentLine = allLines[i];
                int countAllLetters = CounterForLetters(currentLine);
                int countAllMarks = CounterForMarks(currentLine);
                newLines.Add($"Line {i + 1}: {currentLine} ({countAllLetters})({countAllMarks})");
            }
            for (int i = 0; i < newLines.Count; i++)
            {
                File.WriteAllLines("../../../output.txt", newLines);
            }
        }

        private static int CounterForLetters( string currentLine)
        {
            int countLetters = 0;
            for (int i = 0; i < currentLine.Length; i++)
            {
                char symbol = currentLine[i];

                if (char.IsLetter(symbol))
                {
                    countLetters++;
                }
            }

            return countLetters;
        }
        private static int CounterForMarks(string currentLine)
        {
            int countMarks = 0;
            for (int i = 0; i < currentLine.Length; i++)
            {
                char symbol = currentLine[i];
                char[] marks = new char[] { '.', ',', '?', '!', ':', ';', '-', '\'' };
                if (marks.Contains(symbol))
                {
                    countMarks++;
                }
            }

            return countMarks;
        }
    }
}
