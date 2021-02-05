using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DefiningClasses
{
    public class Engine
    {
        private string model;
        private int power;
        private string displacement = "n/a";
        private string efficiency = "n/a";


        public string Model { get => model; set => model = value; }
        public int Power { get => power; set => power = value; }
        public string Displacement { get => displacement; set => displacement = value; }
        public string Efficiency { get => efficiency; set => efficiency = value; }

        public Engine(string model, int power, string displacement, string efficiency)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = displacement;
            this.Efficiency = efficiency;
        }
        public Engine(string model)
        {
            this.Model = model;
        }
    }
}
