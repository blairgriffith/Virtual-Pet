using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class VirtualPet
    {
        public int Hunger { get; set; }
        public int Boredom { get; set; }
        public int Health { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }

        public VirtualPet(string name, string species)
        {
            Name = name;
            Species = species;
            Hunger = 5;
            Boredom = 6;
            Health = 7;
        }

        public VirtualPet AddPet()
        {
            Console.WriteLine("Let's name the new pet in your shelter. What would you like to name your pet?");
            (this.Name) = Console.ReadLine();
            Console.WriteLine($"{this.Name} is a great name! What species is {this.Name}?");
            this.Species = Console.ReadLine();
            return this;
        }
        
    }
}
