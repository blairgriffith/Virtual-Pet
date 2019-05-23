using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    class Menu
    {
        string response = "";
        bool playingGame = true;

        VirtualPet first = new VirtualPet("", "");
        public void StartMenu()
        {

                Console.WriteLine("Please choose one of the following menu options.");
                Console.WriteLine("Type play or exit");
                response = Console.ReadLine().ToLower();

              ////  switch (response)
              //  {
              //      case "play":
              //          Console.WriteLine("Let's name the first pet in your shelter. What would you like to name your pet?");
              //          first.Name = Console.ReadLine();
              //          Console.WriteLine($"{first.Name} is a great name! What species is {first.Name}?");
              //          first.Species = Console.ReadLine();
              //          GameplayMenu();
              //          break;
              //      case "exit":
              //          Console.WriteLine("Thank you for playing!");
              //          playingGame = false;
              //          break;
              //      default:
              //          Console.WriteLine("command not recognized");
              //          break;

              //  }
        }
        public void GameplayMenu()
        {
                Console.WriteLine("\nPlease type one of the following menu options:" +
                    "\npet info - displays species and pet name" +
                    "\npet status - displays pet hunger, boredom, and health" +
                    "\nfeed pet - feeds pet, decreasing hunger" +
                    "\ndoctor visit - takes pet to doctor, increasing health" +
                    "\nexercise - play with your pet, increasing health, decreasing boredom," +
                    "\nand increasing hunger" +
                    "\nexit - exits the game\n");
            do
            {
                response = Console.ReadLine();
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
                    case "doctor visit":
                        first.TakeToDoctor();
                        break;
                    case "exercise":
                        first.PlayWithPet();
                        break;
                    case "exit":
                        playingGame = false;
                        break;
                    default:
                        Console.WriteLine("command not recognized");
                        break;
                }

            } while (playingGame);


            
        }
    }
}
