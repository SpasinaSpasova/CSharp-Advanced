using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guild
    {
        private List<Player> roster;
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count => this.roster.Count;

        public Guild(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.roster = new List<Player>();
        }

        public void AddPlayer(Player player)
        {
            if (this.Capacity > this.roster.Count)
            {
                this.roster.Add(player);
            }
        }

        public bool RemovePlayer(string name)
        {
            Player player = this.roster.FirstOrDefault(x => x.Name == name);
            if (player != null)
            {
                roster.Remove(player);
                return true;
            }
            return false;
        }

        public void PromotePlayer(string name)
        {
            Player player = this.roster.FirstOrDefault(n => n.Name == name);

            if (player.Rank == "Trial")
            {
                player.Rank = "Member";
            }
        }

        public void DemotePlayer(string name)
        {
            Player player = this.roster.FirstOrDefault(n => n.Name == name);

            if (player.Rank != "Trial")
            {
                player.Rank = "Trial";
            }
        }

        public Player[] KickPlayersByClass(string currClass)
        {
            Player[] player = this.roster.Where(c => c.Class == currClass).ToArray();
            this.roster.RemoveAll(c => c.Class == currClass);
            return player;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Players in the guild: {this.Name}");

            foreach (var item in this.roster)
            {
                sb.AppendLine($"{item.ToString()}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}