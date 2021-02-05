using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Trainer
    {
        public string Name { get; set; }
        public int NumberOfBadges { get; set; }
       public List<Pokemon> CollectionOfPokemons { get; set; }
        public Trainer(string name)
        {
            this.Name = name;
            this.NumberOfBadges = 0;
            this.CollectionOfPokemons = new List<Pokemon>();
        }

    }
}
