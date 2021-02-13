using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ListyIterator
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> list = Console.ReadLine().Split(" ").Skip(1).ToList();
            ListyIterator<string> myIterator = new ListyIterator<string>(list);

            string command = Console.ReadLine();

            while (command != "END")
            {

                if (command.Contains("Move"))
                {
                    Console.WriteLine(myIterator.Move());
                }
                else if (command.Contains("HasNext"))
                {
                    Console.WriteLine(myIterator.HasNext());
                }
                else if (command.Contains("Print"))
                {
                    try
                    {
                        myIterator.Print();
                    }
                    catch (InvalidOperationException ex)
                    {

                        Console.WriteLine(ex.Message);
                    }
                }
                command = Console.ReadLine();
            }

        }
    }
}
