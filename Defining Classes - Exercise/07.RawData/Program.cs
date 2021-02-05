using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> allCars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                /* "{model} {engineSpeed} {enginePower} {cargoWeight} {cargoType} {tire1Pressure} {tire1Age} {tire2Pressure} {tire2Age} {tire3Pressure} {tire3Age} {tire4Pressure} {tire4Age}"*/

                string[] info = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string model = info[0];
                int engineSpeed = int.Parse(info[1]);
                int enginePower = int.Parse(info[2]);
                int cargoWeight = int.Parse(info[3]);
                string cargoType = info[4];

                Engine currentEngine = new Engine(engineSpeed, enginePower);

                Cargo currentCargo = new Cargo(cargoWeight, cargoType);

                Tire[] currentTire = new Tire[4]
                {
                    new Tire(double.Parse(info[5]), int.Parse(info[6])),
                    new Tire(double.Parse(info[7]), int.Parse(info[8])),
                    new Tire(double.Parse(info[9]), int.Parse(info[10])),
                    new Tire(double.Parse(info[11]), int.Parse(info[12]))
                };
                Car newCar = new Car(model, currentEngine, currentCargo, currentTire);
                allCars.Add(newCar);
            }
            string command = Console.ReadLine();

            if (command == "fragile")
            {
                //cargo is "fragile" with a tire, whose pressure is  < 1

                allCars = allCars.Where(x => x.Cargo.Type == "fragile").
                  Where(x => x.Tires.Any(x => x.Pressure < 1)).ToList();

                PrintCar(allCars);

            }
            else if (command == "flamable")
            {
                //, whose cargo is "flamable" and have engine power > 250

                allCars = allCars.Where(x => x.Cargo.Type == "flamable").
                  Where(x => x.Engine.Power>250).ToList();

                PrintCar(allCars);
            }
        }

        private static void PrintCar(List<Car> allCars)
        {
            foreach (var item in allCars)
            {
                Console.WriteLine(item.Model);
            }
        }
    }
}
