﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public Engine Engine { get; set; }
        public Tire[] Tires { get; set; }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.Engine = engine;
            this.Tires = tires;
        }
        public void Drive(double distance)
        {
            if (FuelQuantity - (distance * FuelConsumption) / 100 >= 0)
            {
                FuelQuantity -= (distance * FuelConsumption) / 100;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }

        }
        public void WhoIAm()
        {
            Console.WriteLine($"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nHorsePowers: {this.Engine.HorsePower}\nFuelQuantity: {this.FuelQuantity}");

        }

    }
}
