using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    class Shelter
    {
        Menu menuShelter = new Menu();
        VirtualPet shelterPet = new VirtualPet("", "");
        List<VirtualPet> listOfPets = new List<VirtualPet>();
        string response = ("");
        bool playingGame = true;

        public void AddPetToShelter()
        {
            shelterPet.AddPet();
            listOfPets.Add(shelterPet);
            
        }

        public void ListPets()
        {
            Console.WriteLine("|Name        | Hunger | Boredom  | Health |");
            Console.WriteLine("|------------|--------|----------|--------|");

            foreach(var shelterPet in listOfPets)
            {
                Console.WriteLine($"{shelterPet.Name} {shelterPet.Hunger} {shelterPet.Boredom} {shelterPet.Health}");
            }

        }


    }
}
