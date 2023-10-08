using System.Diagnostics;
using System.Net;

namespace PokemonTrainer
{
    public class Startup
    {
        static void Main()
        {
            string command = Console.ReadLine();
            List<Trainer> trainers = new();

            while (command != "Tournament")
            {
                string[] pokemonInfo = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string trainerName = pokemonInfo[0];
                string pokemonName = pokemonInfo[1];
                string element = pokemonInfo[2];
                int health = int.Parse(pokemonInfo[3]);

                Pokemon pokemon = new(pokemonName, element, health);
                Trainer currentTrainer = trainers.SingleOrDefault(t => t.Name == trainerName);
                if (currentTrainer == null)
                {
                    Trainer trainer = new(trainerName, 0, new List<Pokemon>());
                    trainer.Pokemons.Add(pokemon);
                    trainers.Add(trainer);
                }
                else
                {
                    currentTrainer.Pokemons.Add(pokemon);
                }

                command = Console.ReadLine();
            }

            string action = Console.ReadLine();

            while (action != "End")
            {
                if (action == "Fire")
                {
                    foreach (Trainer trainer in trainers)
                    {
                        trainer.GetBadges(action, trainer);
                    }
                }
                else if (action == "Water")
                {
                    foreach (Trainer trainer in trainers)
                    {
                        trainer.GetBadges(action, trainer);
                    }
                }
                else if (action == "Electricity")
                {
                    foreach (Trainer trainer in trainers)
                    {
                        trainer.GetBadges(action, trainer);
                    }
                }
                action = Console.ReadLine();
            }

            foreach (var trainer in trainers.OrderByDescending(t => t.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");
            }
        }
    }
}