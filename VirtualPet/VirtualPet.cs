using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    class VirtualPet
    {
        public int Hunger { get; set; }
        public int Boredom { get; set; }
        public int Health { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }

        public VirtualPet(string name, string species, int hunger, int boredom, int health)
        {
            Name = name;
            Species = species;
            Hunger = hunger;
            Boredom = boredom;
            Health = health;
        }
        public VirtualPet()
        {

        }
    }
}
