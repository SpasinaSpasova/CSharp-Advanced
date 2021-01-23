using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace _08._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contestAndPass = new Dictionary<string, string>();

            SortedDictionary<string, Dictionary<string, int>> courseInfo = new SortedDictionary<string, Dictionary<string, int>> ();


            while (true)
            {
                string input = Console.ReadLine();

                if (input== "end of contests")
                {
                    break;
                }

                string[] information = input.Split(":").ToArray();
                string contest = information[0];
                string password = information[1];

                if (!contestAndPass.ContainsKey(contest))
                {
                    contestAndPass.Add(contest, password);
                    
                }

            }

            while (true)
            {
                string secondInput = Console.ReadLine();

                if (secondInput== "end of submissions")
                {
                    break;
                }

                string[] tokens = secondInput.Split("=>", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string contest = tokens[0];
                string password = tokens[1];
                string username = tokens[2];
                int points = int.Parse(tokens[3]);

                if (contestAndPass.ContainsKey(contest)
                    &&password==contestAndPass[contest])
                    
                {
                    if (courseInfo.ContainsKey(username))
                       
                    {
                        if (courseInfo[username].ContainsKey(contest))
                        {

                            if (courseInfo[username][contest] < points)
                            {
                                courseInfo[username][contest] = points;
                            }
                        }
                        else
                        {
                            courseInfo[username].Add(contest, points);

                        }
                    }
                    else
                    {
                        courseInfo.Add(username, new Dictionary<string, int>());
                        courseInfo[username].Add(contest, points);
                    }
                }

            }
            Dictionary<string, int> bestStudent = new Dictionary<string, int>();

            foreach (var item in courseInfo)
            {
                bestStudent[item.Key] = item.Value.Values.Sum();

            }

            string theBestName = bestStudent.Keys.Max();
            int theBestPoint = bestStudent.Values.Max();

            foreach (var item in bestStudent)
            {
                if (item.Value == theBestPoint)
                {
                    Console.WriteLine($"Best candidate is {item.Key} with total {item.Value} points.");

                }
            }

            Console.WriteLine("Ranking:");

            foreach (var kvp in courseInfo)
            {
                Dictionary<string, int> dict = kvp.Value;
                dict = dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

                Console.WriteLine($"{kvp.Key}");
                foreach (var kvp2 in dict)
                {
                    Console.WriteLine($"#  {kvp2.Key} -> {kvp2.Value}");
                }

            }


        }
    }
}
