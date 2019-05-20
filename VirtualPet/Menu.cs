using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    class Menu
    {
        VirtualPet first = new VirtualPet("", "");
        public void StartMenu()
        {
            string response = "";

                Console.WriteLine("Please choose one of the following menu options.");
                Console.WriteLine("Type play or exit");
                response = Console.ReadLine().ToLower();

                switch (response)
                {
                    case "play":
                        Console.WriteLine("Let's name your first pet.");
                        first.Name = Console.ReadLine();
                        Console.WriteLine($"{first.Name} is a great name! What species is {first.Name}?");
                        first.Species = Console.ReadLine();
                        GameplayMenu();
                        break;
                    case "exit":
                        Console.WriteLine("Thank you for playing!");
                        break;
                }
        }
        public void GameplayMenu()
        {
            
            switch (response)
            {
                case "pet info":
                    GetInfo();
                    break;
                case "pet status":
                    VirtualPet.GetStatus();
                    break;
                case "feed pet":
                    VirtualPet.FeedPet();
                    Console.WriteLine($"Your pet's hunger level is now {Hunger}");
                    break;
                default:
                    Console.WriteLine("command not recognized");
                    break;
            }
        }
    }
}
