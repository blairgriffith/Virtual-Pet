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
        
        Shelter shelter = new Shelter();


        public void GameplayMenu()
        {
            Console.WriteLine("Welcome to Virtual Pet!!\n");
            do
            {
                OrganicPet organicPet = new OrganicPet();
                RobotPet robotPet = new RobotPet();

                shelter.Tick();

                Console.WriteLine("\nPlease type one of the following menu options:\n" +
                    "\nAdd Pet - add a new pet to the shelter\n" +
                    "\nPet Status - displays all pets' names species and stats\n" +
                    "\nFeed Pet - feeds pet, decreasing hunger\n" +
                    "\n    Feed All - feed all pets\n" + 
                    "\nTake to Doctor - increasing health\n" +
                    "\n    Take all to Doctor - same as above for all pets\n" +
                    "\nExercise -increasing health, decreasing boredom, and increasing hunger\n" +
                    "\n    Exercise All - same as above for all pets\n" +
                    "\nAdopt - Remove a selected pet from the shelter\n" +
                    "\nExit - exits the game\n");

                response = Console.ReadLine().ToLower();
                switch (response)
                {
                    case "add pet":
                        switch (pet.ChoosePetType())
                        {
                            case "robot":
                                robotPet = robotPet.AddPet();
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
                        switch (pet.ChoosePetType())
                        {
                            //robo pet equals choose pet w the shelter
                            case "robot":
                                robotPet = robotPet.ChoosePet(shelter);
                                robotPet.FeedPet(robotPet);
                                break;
                            case "organic":
                                organicPet = organicPet.ChoosePet(shelter);
                                organicPet.FeedPet(organicPet);
                                break;
                        }
                        break;
                    case "feed all":
                        switch (pet.ChoosePetType())
                        {
                            case "robot":
                                robotPet.FeedAll(shelter);
                                break;
                            case "organic":
                                organicPet.FeedAll(shelter);
                                break;
                        }
                        break;
                    case "take to doctor":
                        switch (pet.ChoosePetType())
                        {
                            case "robot":
                                robotPet = robotPet.ChoosePet(shelter);
                                robotPet.TakeToDoctor(robotPet);
                                break;
                            case "organic":
                                organicPet = organicPet.ChoosePet(shelter);
                                organicPet.TakeToDoctor(organicPet);
                                break;
                        }
                        break;
                    case "take all to doctor":
                        switch (pet.ChoosePetType())
                        {
                            case "robot":
                                robotPet.TakeToDoctorAll(shelter);
                                break;
                            case "organic":
                                organicPet.TakeToDoctorAll(shelter);
                                break;
                        }
                        break;
                    case "exercise":
                        switch (pet.ChoosePetType())
                        {
                            case "robot":
                                robotPet = robotPet.ChoosePet(shelter);
                                robotPet.Exercise(robotPet);
                                break;
                            case "organic":
                                organicPet = organicPet.ChoosePet(shelter);
                                organicPet.Exercise(organicPet);
                                break;
                        }
                        break;
                    case "exercise all":
                        switch (pet.ChoosePetType())
                        {
                            case "robot":
                                robotPet.ExerciseAll(shelter);
                                break;
                            case "organic":
                                organicPet.ExerciseAll(shelter);
                                break;
                        }
                        break;
                    case "adopt":
                        switch (pet.ChoosePetType())
                        {
                            case "robot":
                                robotPet = robotPet.ChoosePet(shelter);
                                shelter.AdoptRobot(robotPet);
                                break;
                            case "organic":
                                organicPet = organicPet.ChoosePet(shelter);
                                shelter.AdoptOrganic(organicPet);
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
