using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Tire
    {
        public double Pressure { get; set; }
        public int Age { get; set; }
        public Tire(double Pressure, int age)
        {
            this.Pressure = Pressure;
            this.Age = age;
        }
    }
}
