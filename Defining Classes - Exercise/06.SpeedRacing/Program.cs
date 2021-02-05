using System;
using System.Collections.Generic;
using System.Linq;

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
                //"{model} {fuelAmount} {fuelConsumptionFor1km}"
                string[] info = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string model = info[0];
                double fuelAmount = double.Parse(info[1]);
                double fuelConsumptionForOneKm = double.Parse(info[2]);
                Car newCar = new Car(model, fuelAmount, fuelConsumptionForOneKm);
                allCars.Add(newCar);
            }
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] info = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                //"Drive {carModel} {amountOfKm}"

                string carModel = info[1];
                double amountOfKm = double.Parse(info[2]);
                Car current = allCars.FirstOrDefault(x => x.Model == carModel);
                bool isDrive = current.Drive(amountOfKm);
                if (isDrive)
                {
                    current.FuelAmount -= current.FuelConsumptionPerKilometer * amountOfKm;
                    current.TravelledDistance += amountOfKm;
                }
                else
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
                input = Console.ReadLine();
            }
            foreach (var item in allCars)
            {
                Console.WriteLine($"{item.Model} {item.FuelAmount:f2} {item.TravelledDistance}");
            }
        }
    }
}
