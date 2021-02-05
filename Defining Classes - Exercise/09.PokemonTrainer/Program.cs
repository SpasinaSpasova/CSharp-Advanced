using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Trainer> trainersWithPokemons = new List<Trainer>();

            while (input != "Tournament")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string trainerName = tokens[0];
                string pokemonName = tokens[1];
                string pokemonElement = tokens[2];
                int pokemonHealth = int.Parse(tokens[3]);



                Trainer currentTrainer = trainersWithPokemons.FirstOrDefault(x => x.Name == trainerName);

                if (currentTrainer != null)
                {
                    currentTrainer.CollectionOfPokemons.Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));
                }
                else
                {
                    Trainer newTrainer = new Trainer(trainerName);

                    newTrainer.CollectionOfPokemons.Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));

                    trainersWithPokemons.Add(newTrainer);
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "End")
            {
                foreach (Trainer trainer in trainersWithPokemons)
                {

                    if (trainer.CollectionOfPokemons.Any(x => x.Element == input))
                    {
                        trainer.NumberOfBadges++;
                    }
                    else
                    {
                        foreach (Pokemon pokemon in trainer.CollectionOfPokemons)
                        {
                            pokemon.Health-=10;

                        }
                    }
                    trainer.CollectionOfPokemons.RemoveAll(x => x.Health <= 0);
                }


                input = Console.ReadLine();
            }
           

            trainersWithPokemons = trainersWithPokemons.OrderByDescending(x => x.NumberOfBadges).ToList();

            foreach (Trainer trainer in trainersWithPokemons)
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.CollectionOfPokemons.Count}");
            }


        }
    }
}
