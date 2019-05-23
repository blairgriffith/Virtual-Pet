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

        public void AddPet()
        {

                    Console.WriteLine("Let's name the new pet in your shelter. What would you like to name your pet?");
                    (this.Name) = Console.ReadLine();
                    Console.WriteLine($"{this.Name} is a great name! What species is {this.Name}?");
                    this.Species = Console.ReadLine();
        }

        public void GetInfo()
        {
            Console.WriteLine($"Your {Species} is named {Name}");
        }

        //public void GetInfoAll()
        //{

        //}

        public void GetStatus()
        {
            Console.WriteLine($"{Name} has {Hunger} hunger, {Boredom} boredom, and {Health} health.");
        }

        //public void GetStatusAll()
        //{

        //}

        public void FeedPet()
        {
            Hunger--;
            Console.WriteLine($"{Name}'s hunger level is now {Hunger}");
        }

        //public void FeedAll()
        //{

        //}

        public void TakeToDoctor()
        {
            Health++;
            Console.WriteLine($"{Name}'s health level is now {Health}");
        }

        //public void TakeToDoctorAll()
        //{

        //}

        public void PlayWithPet()
        {
            Health++;
            Hunger--;
            Boredom--;
            Console.WriteLine($"{Name} now has {Health} health, {Hunger} hunger, and {Boredom} boredom.");
        }

        //public void PlayWithAll()
        //{

        //}
       
    }
}
