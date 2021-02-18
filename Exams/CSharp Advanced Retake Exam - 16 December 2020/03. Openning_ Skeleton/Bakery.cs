using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakeryOpenning
{
    public class Bakery
    {
        private List<Employee> data;
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count => this.data.Count;
        public Bakery(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.data = new List<Employee>();

        }

        public void Add(Employee employee)
        {
            if (this.data.Count < this.Capacity)
            {
                data.Add(employee);
            }
        }
        public bool Remove(string name)
        {
            Employee toBeRemove = this.data.FirstOrDefault(n => n.Name == name);

            if (toBeRemove!=null)
            {
                this.data.Remove(toBeRemove);
                return true;
            }
            return false;
        }
        public Employee GetOldestEmployee()
        {
            Employee oldest = this.data.OrderByDescending(a => a.Age).FirstOrDefault();

            return oldest;
        }
        public Employee GetEmployee(string name)
        {
            Employee current = this.data.FirstOrDefault(n => n.Name
              == name);

            return current;
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Employees working at Bakery {this.Name}:");
            foreach (var item in this.data)
            {
                sb.AppendLine($"{item.ToString()}");

            }
            return sb.ToString().TrimEnd();
        }

    }
}
