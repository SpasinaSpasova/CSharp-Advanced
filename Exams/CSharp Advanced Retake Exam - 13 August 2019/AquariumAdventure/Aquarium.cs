using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquariumAdventure
{
    public class Aquarium
    {
        
        private List<Fish> fishInPool;

        
        public Aquarium(string name, int capacity, int size)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.Size = size;
            this.fishInPool = new List<Fish>();
        }

       
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Size { get; set; }

      
        public void Add(Fish fish)
        {
            Fish checker = this.fishInPool.FirstOrDefault(f => f.Name == fish.Name);

            if (fishInPool.Count < Capacity && checker == null)
            {
                fishInPool.Add(fish);
            }
        }

       
        public bool Remove(string name)
        {
            Fish fish = fishInPool.FirstOrDefault(x => x.Name == name);
            if (fish != null)
            {
                fishInPool.Remove(fish);
                return true;
            }
            else
            {
                return false;
            }
        }

       
        public Fish FindFish(string name)
        {
            Fish findFish = this.fishInPool.FirstOrDefault(n => n.Name == name);

            return findFish;
        }
        
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Aquarium: {this.Name} ^ Size: {this.Size}");
            foreach (var item in fishInPool)
            {
                sb.AppendLine($"{item.ToString()}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}