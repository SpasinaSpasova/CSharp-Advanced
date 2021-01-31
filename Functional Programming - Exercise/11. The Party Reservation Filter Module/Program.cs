using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._The_Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string cmd = Console.ReadLine();
            List<string> filters = new List<string>();
            while (cmd != "Print")
            {
                string[] arguments = cmd.Split(";");
                string fillter = arguments[0];

                if (fillter == "Add filter")
                {
                    filters.Add(arguments[1] + " " + arguments[2]);

                }
                else if (fillter == "Remove filter")
                {
                    filters.Remove(arguments[1] + " " + arguments[2]);
                }

                cmd = Console.ReadLine();
            }

            foreach (string filter in filters)
            {
                string[] arg = filter.Split(' ');

                if (arg[0] == "Starts")
                {
                    guests = guests.Where(p => !p.StartsWith(arg[2])).ToList();
                }
                else if (arg[0] == "Ends")
                {
                    guests = guests.Where(p => !p.EndsWith(arg[2])).ToList();
                }
                else if (arg[0] == "Length")
                {
                    guests = guests.Where(p => p.Length != int.Parse(arg[1])).ToList();
                }
                else if (arg[0] == "Contains")
                {
                    guests = guests.Where(p => !p.Contains(arg[1])).ToList();
                }
            }


            if (guests.Any())
            {
                Console.WriteLine(string.Join(" ", guests));
            }

        }


    }
}
