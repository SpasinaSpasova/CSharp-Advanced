using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SoftUniParking
{
    public class Parking
    {
        private List<Car> cars;
        private int capacity;
        public int Count
        {
            get => cars.Count;
        }
        public Parking(int capacity)
        {
            this.cars = new List<Car>();
            this.capacity = capacity;
           
        }

        public string AddCar(Car Car)
        {
            var currentCar = cars.Where(x => x.RegistrationNumber == Car.RegistrationNumber).FirstOrDefault();

            if (currentCar != null)
            {
                return "Car with that registration number, already exists!";
            }
            if (cars.Count >= capacity)
            {
                return "Parking is full!";


            }
            else
            {
                cars.Add(Car);
                return $"Successfully added new car {Car.Make} {Car.RegistrationNumber}";
            }
        }
        public string RemoveCar(string RegistrationNumber)
        {
            var currentCar = cars.Where(x => x.RegistrationNumber == RegistrationNumber).FirstOrDefault();

            if (currentCar == null)
            {
                return "Car with that registration number, doesn't exist!";
            }
            else
            {
                cars.Remove(currentCar);
                return $"Successfully removed {currentCar.RegistrationNumber}";
            }
        }
        public Car GetCar(string RegistrationNumber)
        {
            return cars.Where(x => x.RegistrationNumber == RegistrationNumber).FirstOrDefault();
        }
        public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers)
        {
            for (int i = 0; i < RegistrationNumbers.Count; i++)
            {
                cars.RemoveAll(x => x.RegistrationNumber == RegistrationNumbers[i]);
            }
            
        }
     
    }
}
