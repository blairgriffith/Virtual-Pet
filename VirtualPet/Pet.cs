using System;
using System.Collections.Generic;
using System.Text;

namespace OrganicPet
{
    public class Pet
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Boredom { get; set; }
        Shelter shelter = new Shelter();

        public Pet(string name, string species)
        {
            Name = name;
            Species = species;
            Boredom = 7;
        }

        public string ChoosePetType()
        {
            //Make switch case with default...later
            Console.WriteLine("Choose a pet type: Robot or Organic");
            return Console.ReadLine();
        }

        
        
            
        



    }
}
