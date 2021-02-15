using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic
{
    public class Clinic
    {
        private List<Pet> data;
        public int Capacity { get; set; }

        public int Count { get { return data.Count; } }
        public Clinic(int capacity)
        {
            this.Capacity = capacity;
            this.data = new List<Pet>();
        }

        public void Add(Pet pet)
        {
            if (this.data.Count < this.Capacity)
            {
                data.Add(pet);
            }
        }

        //!!!!!!!!!
        //!!!!!!!!!
        //!!!!!!!!!
        public bool Remove(string name)
        {
            Pet pet = this.data.FirstOrDefault(x => x.Name == name);
            if (pet != null)
            {
                data.Remove(pet);
                return true;
            }
            return false;
        }
        public Pet GetPet(string name, string owner)
        {
            Pet pet = this.data.FirstOrDefault(x => x.Name == name && x.Owner == owner);
            return pet;
        }

        public Pet GetOldestPet()
        {

            return this.data.OrderByDescending(x => x.Age).FirstOrDefault();
        }
        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("The clinic has the following patients:");
            foreach (var item in this.data)
            {
                sb.AppendLine($"Pet {item.Name} with owner: {item.Owner}");
            }
            return sb.ToString();
        }

    }
}
