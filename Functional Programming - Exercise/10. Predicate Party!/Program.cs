using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guest = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string command = Console.ReadLine();

            while (command != "Party!")
            {
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string firstCmd = tokens[0];
                string startOrEndOrLen = tokens[1];
                if (firstCmd == "Remove")
                {
                    if (startOrEndOrLen == "StartsWith")
                    {
                        guest = guest.Where(x => !x.StartsWith(tokens[2])).ToList();
                    }
                    else if (startOrEndOrLen == "EndsWith")
                    {
                        guest = guest.Where(x => !x.EndsWith(tokens[2])).ToList();

                    }
                    else if (startOrEndOrLen == "Length")
                    {
                        guest = guest.Where(x => x.Length != int.Parse(tokens[2])).ToList();

                    }
                }
                else if (firstCmd == "Double")
                {
                    if (startOrEndOrLen == "StartsWith")
                    {
                        DoubleStart(guest, tokens);
                    }
                    else if (startOrEndOrLen == "EndsWith")
                    {
                        DoubleEnd(guest, tokens);

                    }
                    else if (startOrEndOrLen == "Length")
                    {

                        DoubleLen(guest, tokens);
                    }
                }


                command = Console.ReadLine();
            }
            if (guest.Count > 0)
            {
                Console.WriteLine(string.Join(", ", guest) + " are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }


        private static void DoubleLen(List<string> guest, string[] tokens)
        {
            for (int i = 0; i < guest.Count; i++)
            {
                if (guest[i].Length == int.Parse(tokens[2]))
                {
                    guest.Insert(i, guest[i]);
                    ;
                }
                i++;
            }
        }
        private static void DoubleStart(List<string> guest, string[] tokens)
        {
            for (int i = 0; i < guest.Count; i++)
            {

                if (guest[i].Contains(tokens[2]))
                {
                    guest.Insert(i, guest[i]);

                }
                i++;
            }
        }
        private static void DoubleEnd(List<string> guest, string[] tokens)
        {
            for (int i = 0; i < guest.Count; i++)
            {

                if (guest[i].Contains(tokens[2]))
                {
                    guest.Insert(i, guest[i]);

                }
                i++;
            }
        }
    }
}
