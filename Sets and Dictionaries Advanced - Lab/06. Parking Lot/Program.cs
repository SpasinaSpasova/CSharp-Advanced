using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberCars = Console.ReadLine();
            HashSet<string> cars = new HashSet<string>();
            while (numberCars != "END")
            {
                string[] tokens = numberCars.Split(", ").ToArray();
                string command = tokens[0];
                string num = tokens[1];
                if (command == "IN")
                {
                    cars.Add(num);
                }
                else if (command == "OUT")
                {
                    if (cars.Count > 0)
                    {
                        cars.Remove(num);
                    }
                }


                numberCars = Console.ReadLine();
            }
            if (cars.Count > 0)
            {

                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
