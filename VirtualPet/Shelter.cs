using System;
using System.Collections.Generic;
using System.Text;

namespace OrganicPet
{
    public class Shelter
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
            Console.WriteLine("|Name   |Species     | Hunger/Oil | Boredom  | Health/Performance |");
            Console.WriteLine("|-------|---------|------------|----------|--------------------|");

            Console.WriteLine("Organic Pets:");
            foreach (var pet in listOfOrganicPets)
            {
                Console.WriteLine($"| {pet.Name} |{pet.Species} | {pet.Hunger} | {pet.Boredom} | {pet.Health}|");
            }
            Console.WriteLine("Robot Pets:");
            foreach (var pet in listOfRobotPets)
            {
                Console.WriteLine($"| {pet.Name} |{pet.Species} | {pet.Oil} | {pet.Boredom} | {pet.Performance}|");
            }
        }

    }
}
