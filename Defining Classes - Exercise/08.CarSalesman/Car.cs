using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DefiningClasses
{
    public class Car
    {
        private string model;
        private Engine engine;
        private string weight = "n/a";
        private string color = "n/a";
        public string Model { get => model; set => model = value; }
        public Engine Engine { get => engine; set => engine = value; }
        public string Weight { get => weight; set => weight = value; }
        public string Color { get => color; set => color = value; }
        public Car(string model,Engine engine,string weight,string color)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
            this.Color = color;
        }
    }
}
