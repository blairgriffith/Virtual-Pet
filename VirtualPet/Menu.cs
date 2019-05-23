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
        public void AddPet()
        {
            Console.WriteLine("Welcome to Virtual Pet!! Type play or exit");
            Console.ReadLine();

            switch (response)
            {
                case "play":
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
