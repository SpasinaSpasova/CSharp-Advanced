using System;

namespace _08.Threeuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] commands = Console.ReadLine().Split(" ");

            string name = commands[0] + " " + commands[1];
            string town="";
            if (commands.Length>4)
            {
               town= commands[3] + " " + commands[4];
            }
            else
            {
                town = commands[3];
            }
            Threeuple<string, string,string> first = new Threeuple<string, string,string>(name, commands[2],town);
            Console.WriteLine(first);

            string[] commands2 = Console.ReadLine().Split(" ");
            bool IsDrunk = commands2[2] == "drunk" ? true : false;
            Threeuple<string, int,bool> second = new Threeuple<string, int,bool>(commands2[0], int.Parse(commands2[1]),IsDrunk);
            Console.WriteLine(second);

            string[] commands3 = Console.ReadLine().Split(" ");

            Threeuple<string, double,string> third = new Threeuple<string, double, string>(commands3[0], double.Parse(commands3[1]),commands3[2]);
            Console.WriteLine(third);
        }
    }
}
