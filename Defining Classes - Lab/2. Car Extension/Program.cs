using System;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "vk";
            car.Model = "pp";
            car.Year = 1998;
            car.FuelQuantity = 222;
            car.FuelConsumption = 222;
            car.Drive(2000);
            car.WhoIAm();
        }
    }
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        public void Drive(double distance)
        {
            if (FuelQuantity-(distance* FuelConsumption)>=0)
            {
                FuelQuantity -= (distance * FuelConsumption);
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }

        }
        public void WhoIAm()
        {
            Console.WriteLine($"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel: {this.FuelQuantity:F2}L");

        }

    }
}
