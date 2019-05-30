using System;
using System.Collections.Generic;
using System.Text;

namespace OrganicPet
{
    class Shelter
    {
        //OrganicPet organicPet = new OrganicPet();
        //RobotPet robotPet = new RobotPet();
        public List<OrganicPet> listOfOrganicPets = new List<OrganicPet>();
        public List<RobotPet> listOfRobotPets = new List<RobotPet>();
        int choice;


        //add pets to appropriate lists
        public void AddOrganicPetToShelter(OrganicPet organicPet)
        {
            listOfOrganicPets.Add(organicPet);
        }
        public void AddRobotPetToShelter(RobotPet robotPet)
        {
            listOfRobotPets.Add(robotPet);
        }

        
        //methods for all pets
        public void GetStatusAll()
        {
            Console.WriteLine("|Name        | Hunger/Oil | Boredom  | Health/Performance |");
            Console.WriteLine("|------------|------------|----------|--------------------|");

            foreach(var pet in listOfOrganicPets)
            {
                Console.WriteLine("Organic Pets:");
                Console.WriteLine($"| {pet.Name} | {pet.Hunger} | {pet.Boredom} | {pet.Health}|");
            }
            foreach (var pet in listOfRobotPets)
            {
                Console.WriteLine("Robot Pets:");
                Console.WriteLine($"| {pet.Name} | {pet.Oil} | {pet.Boredom} | {pet.Performance}|");
            }
        }

    }
}
