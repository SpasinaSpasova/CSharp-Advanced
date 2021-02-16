using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Parking
{
    public class Parking
    {
        private List<Car> data;

        public string Type { get; set; }

        public int Capacity { get; set; }

        public int Count {  get => this.data.Count;  }

        public Parking(string type, int capacity)
        {
            this.Type = type;
            this.Capacity = capacity;
            data = new List<Car>();
        }
        public void Add(Car car)
        {
            if (this.data.Count < this.Capacity)
            {
                data.Add(car);
            }
        }
        public bool Remove(string manufacturer, string model)
        {
            //!!!!!
            Car current = this.data.Find(x => x.Manufacturer == manufacturer && x.Model == model);

            if (current != null)
            {
                data.Remove(current);
                return true;
            }
            return false;

        }

        public Car GetLatestCar()
        {
            //!!!!!

            return  data.OrderByDescending(x => x.Year).FirstOrDefault();

           

        }
        public Car GetCar(string manufacturer, string model)
        {
            return data.FirstOrDefault(x => x.Manufacturer == manufacturer && x.Model == model);
        }
        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The cars are parked in {this.Type}:");
            sb.AppendLine(string.Join(Environment.NewLine, data));
            return sb.ToString();
        }
    }
}
