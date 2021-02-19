using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Christmas
{
    class Bag
    {
        private List<Present> data;

        public Bag(string color, int capacity)
        {
            this.Color = color;
            this.Capacity = capacity;
            this.data = new List<Present>();

        }

        public string Color { get; set; }
        public int Capacity { get; set; }
        public int Count => this.data.Count;

        public void Add(Present present)
        {
            if (this.data.Count < this.Capacity)
            {
                data.Add(present);
            }
        }
        public bool Remove(string name)
        {
            Present present = this.data.FirstOrDefault(x => x.Name == name);
            if (present != null)
            {
                data.Remove(present);
                return true;
            }
            return false;
        }

        public Present GetHeaviestPresent()
        {
            Present current = this.data.OrderByDescending(x => x.Weight).FirstOrDefault();
            return current;
        }
        public Present GetPresent(string name)
        {
            Present current = this.data.FirstOrDefault(x=>x.Name==name);
            return current;
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.Color} bag contains:");

            foreach (var present in data)
            {
                sb.AppendLine(present.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}