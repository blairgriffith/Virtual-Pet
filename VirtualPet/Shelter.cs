using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    class Shelter
    {
        Menu menuShelter = new Menu();
        VirtualPet shelterPet = new VirtualPet("", "");
        List<VirtualPet> listOfPets = new List<VirtualPet> ();
        string response = ("");

        public void AddPet()
        {
            Console.WriteLine("Welcome to Virtual Pet!! Type play or exit");
            Console.ReadLine();
            switch (response)
            {
                case "play":
                    Console.WriteLine("Let's name the first pet in your shelter. What would you like to name your pet?");
                    (shelterPet.Name) = Console.ReadLine();
                    Console.WriteLine($"{shelterPet.Name} is a great name! What species is {shelterPet.Name}?");
                    shelterPet.Species = Console.ReadLine();
                    listOfPets.Add(shelterPet);
                    menuShelter.GameplayMenu();
                    break;
                case "exit":
                    Console.WriteLine("Thank you for playing!");
                    playingGame = false;
                    break;
                default:
                    Console.WriteLine("command not recognized");
                    break;

            }
        }

        public void listPets()
        {

        }
 
    }
}
