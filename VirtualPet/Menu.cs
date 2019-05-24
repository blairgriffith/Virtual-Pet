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
        Shelter shelter = new Shelter();

        public void GameplayMenu()
        {
            do
            {
                Console.WriteLine("Welcome to Virtual Pet!!\n");
                Console.WriteLine("\nPlease type one of the following menu options:\n" +
                    "\nAdd Pet - add a new pet to the shelter\n" +
                    "\nList Pets - shows a list of all pets and their statuses\n" +
                    "\nPet Info - displays species and pet name\n" +
                    "\nPet Status - displays pet hunger, boredom, and health\n" +
                    "\nFeed Pet - feeds pet, decreasing hunger\n" +
                    "\nFeed All - feed all pets\n" + 
                    "\nDoctor Visit - takes pet to doctor, increasing health\n" +
                    "\nExercise - play with your pet, increasing health, decreasing boredom, and" +
                    "\nincreasing hunger\n" +
                    "\nExit - exits the game\n");

                response = Console.ReadLine().ToLower();
                switch (response)
                {
                    case "add pet":
                        shelter.AddPetToShelter();
                        break;
                    case "list pets":
                        shelter.ListPets();
                        break;
                    case "pet info":
                        first.GetInfo();
                        break;
                    case "pet status":
                        first.GetStatus();
                        break;
                    case "feed pet":
                        first.FeedPet();
                        break;
                    case "feed all":
                        shelter.FeedAll();
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
