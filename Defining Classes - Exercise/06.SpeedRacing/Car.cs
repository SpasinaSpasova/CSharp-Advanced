using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DefiningClasses
{
    public class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }
        public Car(string model,double fuelAmount,double fuelConsumptionPerKilometer)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
        }
        public bool Drive(double distance)
        {
            if (FuelAmount>=FuelConsumptionPerKilometer*distance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
