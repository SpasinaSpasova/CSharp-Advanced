using System;
using System.Collections.Generic;

namespace _07._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vip = new HashSet<string>();
            HashSet<string> regular = new HashSet<string>();
          
            while (true)
            {
                string guest = Console.ReadLine();
                if (guest == "END")
                {

                    break;
                }
                if (guest != "PARTY")
                {
                    char current = guest[0];

                    if (char.IsDigit(current))
                    {
                        vip.Add(guest);
                    }
                    else
                    {
                        regular.Add(guest);
                    }

                }
                else
                {
                    while (guest != "END")
                    {

                        guest = Console.ReadLine();
                        if (guest=="END")
                        {
                            Console.WriteLine(vip.Count+regular.Count);
                            if (vip.Count>0)
                            {
                                foreach (var item in vip)
                                {
                                    Console.WriteLine(item);
                                }
                            }
                            if (regular.Count>0)
                            {
                                foreach (var item in regular)
                                {
                                    Console.WriteLine(item);
                                }
                            }
                            return; 
                        }
                        char current = guest[0];

                        if (char.IsDigit(current))
                        {
                            vip.Remove(guest);
                        }
                        else
                        {
                            regular.Remove(guest);
                        }
                    }
                }

            }
        }
    }
}
