using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonGame
{
    public class Pokemon
    {

        public Pokemon(string name, string element, int health)
        {
            this.Name = name;
            this.Element = element;
            this.Health = health;
        }


        public string Name { get; private set; }

        public string Element { get; private set; }

        public int Health { get; private set; }


        public void RemoveHealth()
        {
            this.Health -= 10;
        }



    }
}