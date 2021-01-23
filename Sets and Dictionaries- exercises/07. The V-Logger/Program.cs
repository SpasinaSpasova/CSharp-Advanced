using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _07._The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, HashSet<string>>> vloggersInfo = new Dictionary<string, Dictionary<string, HashSet<string>>>();

            string input = Console.ReadLine();

            while (input!= "Statistics")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string action = tokens[1];

                if (action== "joined")
                {
                    string vlogger = tokens[0];
                    if (!vloggersInfo.ContainsKey(vlogger))
                    {
                        vloggersInfo.Add(vlogger, new Dictionary<string, HashSet<string>>());
                        vloggersInfo[vlogger].Add("followers", new HashSet<string>());
                        vloggersInfo[vlogger].Add("following", new HashSet<string>());
                    }
                   
                }
                else if (action == "followed")
                {
                    string vlogger2 = tokens[2];
                    string vlogger1 = tokens[0];
                    if (vloggersInfo.ContainsKey(vlogger1)
                        && vloggersInfo.ContainsKey(vlogger2)
                        && vlogger1 != vlogger2)
                    {
                        vloggersInfo[vlogger1]["following"].Add(vlogger2);
                        vloggersInfo[vlogger2]["followers"].Add(vlogger1);
                    }
                }


                input = Console.ReadLine();
            }
            Console.WriteLine($"The V-Logger has a total of {vloggersInfo.Count} vloggers in its logs.");

            int count = 1;

            foreach (var item in vloggersInfo.OrderByDescending(x => x.Value["followers"].Count).ThenBy(x => x.Value["following"].Count))
            {
                Console.WriteLine($"{count}. {item.Key} : {item.Value["followers"].Count} followers, {item.Value["following"].Count} following");
                if (count == 1)
                {
                    foreach (var item2 in item.Value["followers"].OrderBy(x => x))
                    {
                        Console.WriteLine($"*  {item2}");
                    }
                }
                count++;

            }
        }
    }
}
