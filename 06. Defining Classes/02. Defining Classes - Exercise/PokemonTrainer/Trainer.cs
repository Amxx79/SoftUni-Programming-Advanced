using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainer
{
    public class Trainer
    {
        //•	Name
        //•	Number of badges
        //•	A collection of pokemon

        private string name;
        private int numberOfBadges;
        private List<Pokemon> pokemons;

        public Trainer(string name, int numberOfBadges, List<Pokemon> pokemons)
        {
            this.Name = name;
            this.numberOfBadges = numberOfBadges;
            this.Pokemons = pokemons;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int NumberOfBadges
        {
            get { return numberOfBadges; }
            set { numberOfBadges = value; }
        }
        public List<Pokemon> Pokemons
        {
            get { return pokemons; }
            set { pokemons = value; }
        }

        public void GetBadges(string element, Trainer trainer)
        {
            bool dontHaveThisElement = false;
            foreach (var pokemon in this.Pokemons)
            {
                if (pokemon.Element == element)
                {
                    numberOfBadges++;
                    dontHaveThisElement = true;
                }
                
            }
            if (dontHaveThisElement == false)
            {
                for (int i = 0; i < this.Pokemons.Count; i++)
                {
                    Pokemons[i].Health -= 10;
                    if (Pokemons[i].Health <= 0)
                    {
                        Pokemons.Remove(Pokemons[i]);
                        i--;
                    }
                }
            }
        }

    }
}
