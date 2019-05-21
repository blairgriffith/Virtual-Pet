using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    class Menu
    {
        string response = "";

        VirtualPet first = new VirtualPet("", "");
        public void StartMenu()
        {
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
                    default:
                        Console.WriteLine("command not recognized");
                    break;

                }
        }
        public void GameplayMenu()
        {
            
            switch (response)
            {
                case "pet info":
                    first.GetInfo();
                    break;
                case "pet status":
                    first.GetStatus();
                    break;
                case "feed pet":
                    first.FeedPet();
                  
                    break;
                default:
                    Console.WriteLine("command not recognized");
                    break;
            }
        }
    }
}
