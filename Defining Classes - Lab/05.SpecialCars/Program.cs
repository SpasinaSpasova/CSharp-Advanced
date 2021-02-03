using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Tire[]> tires = new List<Tire[]>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            while (input != "No more tires")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                Tire[] currentTire = new Tire[4]
               {
                    new Tire(int.Parse(tokens[0]), double.Parse(tokens[1])),
                    new Tire(int.Parse(tokens[2]), double.Parse(tokens[3])),
                    new Tire(int.Parse(tokens[4]), double.Parse(tokens[5])),
                    new Tire(int.Parse(tokens[6]), double.Parse(tokens[7]))
               };
                tires.Add(currentTire);

                input = Console.ReadLine();
            }
            input = Console.ReadLine();

            while (input != "Engines done")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                Engine currentEngine = new Engine(int.Parse(tokens[0]), double.Parse(tokens[1]));

                engines.Add(currentEngine);



                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (input != "Show special")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string make = tokens[0];
                string model = tokens[1];
                int year = int.Parse(tokens[2]);
                double fuelQuantity = double.Parse(tokens[3]);
                double fuelConsumption = double.Parse(tokens[4]);
                int engineIndex = int.Parse(tokens[5]);
                int tireIndex = int.Parse(tokens[6]);


                if (engineIndex >= 0 && tireIndex >= 0 && tireIndex < tires.Count && engineIndex < engines.Count)
                {
                    Car newCar = new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], tires[tireIndex]);
                    cars.Add(newCar);
                }

                input = Console.ReadLine();
            }

            cars = cars.Where(x => x.Year >= 2017 && x.Engine.HorsePower > 330 && x.Tires.Sum(y => y.Pressure) >= 9 && x.Tires.Sum(y => y.Pressure) <= 10).ToList();

            if (cars.Any())
            {
                foreach (var car in cars)
                {
                    car.Drive(20);
                    car.WhoIAm();
                }
            }
        }
    }

}


