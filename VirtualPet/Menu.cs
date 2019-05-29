using System;
using System.Collections.Generic;
using System.Text;

namespace OrganicPet
{
    class Menu
    {
        string response = "";
        bool playingGame = true;

        OrganicPet organicPet = new OrganicPet();
        RobotPet robotPet = new RobotPet();
        Shelter shelter = new Shelter();

        public void GameplayMenu()
        {
            Console.WriteLine("Welcome to Virtual Pet!!\n");
            do
            {
                Console.WriteLine("\nPlease type one of the following menu options:\n" +
                    "\nAdd Pet - add a new pet to the shelter\n" +
                    "\nPet Status - displays all pets' names species and stats\n" +
                    "\nFeed Pet - feeds pet, decreasing hunger\n" +
                    "\n    Feed All - feed all pets\n" + 
                    "\nTake to Doctor - increasing health\n" +
                    "\n    Take all to Doctor - same as above for all pets\n" +
                    "\nExercise -increasing health, decreasing boredom, and increasing hunger\n" +
                    "\n    Exercise All - same as above for all pets\n" +
                    "\nExit - exits the game\n");

                response = Console.ReadLine().ToLower();
                switch (response)
                {
                    case "add pet":
                        shelter.AddPetToShelter();
                        break;
                    case "pet status":
                        shelter.GetStatusAll();
                        break;
                    case "feed pet":
                        shelter.ChoosePet();
                        shelter.FeedPet();
                        break;
                    case "feed all":
                        shelter.FeedAll();
                        break;
                    case "take to doctor":
                        shelter.ChoosePet();
                        shelter.TakeToDoctor();
                        break;
                    case "take all to doctor":
                        shelter.TakeToDoctorAll();
                        break;
                    case "exercise":
                        shelter.ChoosePet();
                        shelter.Exercise();
                        break;
                    case "exercise all":
                        shelter.ExerciseAll();
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
