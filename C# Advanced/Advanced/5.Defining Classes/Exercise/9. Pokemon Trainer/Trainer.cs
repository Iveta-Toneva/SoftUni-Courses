using PokemonGame;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonGame
{
   public class Trainer
    {
        public Trainer(string name)
        {
            this.Name = name;
            this.Badges = 0;
            this.Pokemons = new List<Pokemon>();
        }


        public string Name { get; private set; }

        public int Badges { get; private set; }

        public List<Pokemon> Pokemons { get; private set; }


        public void GiveBadge()
        {
            this.Badges++;
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Badges} {this.Pokemons.Count}";
        }



    }
}
