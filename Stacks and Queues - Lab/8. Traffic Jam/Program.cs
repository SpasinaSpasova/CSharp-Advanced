using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOffCars = int.Parse(Console.ReadLine());

            string car = Console.ReadLine();
            Queue<string> carsInJam = new Queue<string>();
            int count = 0;
            while (car != "end")
            {
                if (car != "green")
                {
                    carsInJam.Enqueue(car);
                }
                else
                {



                    for (int i = 0; i < numOffCars; i++)
                    {

                        if (carsInJam.Count > 0)
                        {


                            string theCar = carsInJam.Dequeue();
                            Console.WriteLine($"{theCar} passed!");
                            count++;
                        }
                    }


                }
                car = Console.ReadLine();
            }
            Console.WriteLine($"{count} cars passed the crossroads.");

        }
    }
}
