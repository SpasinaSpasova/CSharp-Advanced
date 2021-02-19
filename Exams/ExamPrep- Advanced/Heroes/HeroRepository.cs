using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heroes
{
    class HeroRepository
    {
        private List<Hero> data;
        public HeroRepository()
        {
            this.data = new List<Hero>(0);
        }
        public int Count => this.data.Count;
        public void Add(Hero hero)
        {
            data.Add(hero);
        }
        public bool Remove(string name)
        {
            Hero hero = this.data.FirstOrDefault(x => x.Name == name);
            if (hero != null)
            {
                data.Remove(hero);
                return true;
            }
            return false;
        }
        public Hero GetHeroWithHighestStrength()
        {
            Hero hero = this.data.OrderByDescending(x => x.Item.Strength).FirstOrDefault();
            return hero;
        }
        public Hero GetHeroWithHighestAbility()
        {
            Hero hero = this.data.OrderByDescending(x => x.Item.Ability).FirstOrDefault();
            return hero;
        }
        public Hero GetHeroWithHighestIntelligence()
        {
            Hero hero = this.data.OrderByDescending(x => x.Item.Intelligence).FirstOrDefault();
            return hero;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var hero in data)
            {
                sb.AppendLine($"Hero: {hero.Name} - {hero.Level}lvl");
                sb.AppendLine($"Item:");
                sb.AppendLine($"    * Strength: {hero.Item.Strength}");
                sb.AppendLine($"    * Ability: {hero.Item.Ability}");
                sb.AppendLine($"    * Intelligence: {hero.Item.Intelligence}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}