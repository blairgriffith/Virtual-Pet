using System;
using System.Collections.Generic;
using System.Text;

namespace OrganicPet
{
    public class Pet
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Hunger { get; set; }
        public int Boredom { get; set; }
        public int Health { get; set; }

        public Pet(string name, string species)
        {
            Name = name;
            Species = species;
            Hunger = 6;
            Boredom = 7;
            Health = 8;
                             
        }

        public Pet AddPet()
        {
            Console.WriteLine("Let's name the new pet in your shelter. What would you like to name your pet?");
            (this.Name) = Console.ReadLine();
            Console.WriteLine($"{this.Name} is a great name! What species is {this.Name}?");
            this.Species = Console.ReadLine();
            return this;
        }






    }
}
