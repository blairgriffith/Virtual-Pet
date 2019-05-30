using System;
using System.Collections.Generic;
using System.Text;

namespace OrganicPet
{
    class Menu
    {
        string response = "";
        bool playingGame = true;
        Pet pet = new Pet("","");
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
                        pet.ChoosePetType();
                        switch (pet.ChoosePetType())
                        {
                            case "robot":
                                robotPet.AddPet();
                                shelter.AddRobotPetToShelter(robotPet);
                                break;
                            case "organic":
                                organicPet.AddPet();
                                shelter.AddOrganicPetToShelter(organicPet);
                                break;
                        }
                        break;
                    case "pet status":
                        shelter.GetStatusAll();
                        break;
                    case "feed pet":
                        pet.ChoosePetType();
                        switch (pet.ChoosePetType())
                        {
                            case "robot":
                                robotPet.FeedPet();
                                break;
                            case "organic":
                                organicPet.FeedPet();
                                break;
                        }
                        break;
                    case "feed all":
                        pet.ChoosePetType();
                        switch (pet.ChoosePetType())
                        {
                            case "robot":
                                robotPet.FeedAll();
                                break;
                            case "organic":
                                organicPet.FeedAll();
                                break;
                        }
                        break;
                    case "take to doctor":
                        pet.ChoosePetType();
                        switch (pet.ChoosePetType())
                        {
                            case "robot":
                                robotPet.TakeToDoctor();
                                break;
                            case "organic":
                                organicPet.TakeToDoctor();
                                break;
                        }
                        break;
                    case "take all to doctor":
                        pet.ChoosePetType();
                        switch (pet.ChoosePetType())
                        {
                            case "robot":
                                robotPet.TakeToDoctorAll();
                                break;
                            case "organic":
                                organicPet.TakeToDoctorAll();
                                break;
                        }
                        break;
                    case "exercise":
                        pet.ChoosePetType();
                        switch (pet.ChoosePetType())
                        {
                            case "robot":
                                robotPet.Exercise();
                                break;
                            case "organic":
                                organicPet.Exercise();
                                break;
                        }
                        break;
                    case "exercise all":
                        pet.ChoosePetType();
                        switch (pet.ChoosePetType())
                        {
                            case "robot":
                                robotPet.ExerciseAll();
                                break;
                            case "organic":
                                organicPet.ExerciseAll();
                                break;
                        }
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
