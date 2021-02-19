using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rabbits
{
    public class Cage
    {
        private List<Rabbit> data;
        public Cage(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.data = new List<Rabbit>();
        }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count => this.data.Count;

        public void Add(Rabbit rabbit)
        {
            if (this.Capacity > this.data.Count)
            {
                this.data.Add(rabbit);
            }
        }

        public bool RemoveRabbit(string name)
        {
            Rabbit current = this.data.FirstOrDefault(n => n.Name == name);

            if (current != null)
            {
                this.data.Remove(current);
                return true;

            }
            return false;
        }

        public void RemoveSpecies(string species)
        {
            this.data.RemoveAll(x => x.Species == species);
        }
        public Rabbit SellRabbit(string name)
        {
            Rabbit current = this.data.FirstOrDefault(n => n.Name == name);
            if (current != null)
            {

                current.Available = false;
            }
            return current;
        }
        public Rabbit[] SellRabbitsBySpecies(string species)
        {
            Rabbit[] current = this.data.Where(x => x.Species == species).ToArray();
            foreach (var item in current)
            {
                item.Available = false;
            }
            return current;
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Rabbits available at {this.Name}:");

            foreach (var item in this.data.Where(x => x.Available == true))
            {
                sb.AppendLine($"{item.ToString()}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
