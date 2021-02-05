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
            List<Engine> engines = new List<Engine>();

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] engineInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string model = engineInfo[0];
                int power = int.Parse(engineInfo[1]);

                string displacement = "n/a";
                string efficiency = "n/a";

                //"{model} {power} {displacement} {efficiency}"

                if (engineInfo.Length == 4)
                {
                    displacement = engineInfo[2];
                    efficiency = engineInfo[3];

                }
                else if (engineInfo.Length == 3 && char.IsDigit(engineInfo[2], 0))
                {
                    displacement = engineInfo[2];
                }
                else if(engineInfo.Length == 3 && char.IsLetter(engineInfo[2], 0))
                {

                    efficiency = engineInfo[2];
                }
                Engine newEngine = new Engine(model, power, displacement, efficiency);
                engines.Add(newEngine);
            }

            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string model = carInfo[0];
                Engine currEngine = engines.Where(x => x.Model == carInfo[1]).FirstOrDefault();

                string weight = "n/a";
                string color = "n/a";

                // "{model} {engine} {weight} {color}" 

                if (carInfo.Length == 4)
                {
                    weight = carInfo[2];
                    color = carInfo[3];

                }
                else if (carInfo.Length == 3 && char.IsDigit(carInfo[2], 0))
                {
                    weight = carInfo[2];
                }
                else if (carInfo.Length == 3 && char.IsLetter(carInfo[2], 0))
                {

                    color = carInfo[2];
                }
                Car newCar = new Car(model, currEngine, weight, color); ;
                cars.Add(newCar);
            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
                Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                Console.WriteLine($"  Weight: {car.Weight}");
                Console.WriteLine($"  Color: {car.Color}");
            }
        }

    }
}
