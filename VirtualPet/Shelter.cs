using System;
using System.Collections.Generic;
using System.Text;

namespace OrganicPet
{
    public class Shelter
    {
        public List<OrganicPet> listOfOrganicPets = new List<OrganicPet>();
        public List<RobotPet> listOfRobotPets = new List<RobotPet>();
        

        
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
            Console.WriteLine("\n| Name | Species | Hunger/Oil | Boredom | Health/Performance |\n");

            Console.WriteLine("Organic Pets:\n");
            foreach (var pet in listOfOrganicPets)
            {
                Console.WriteLine($"|  {pet.Name}  |  {pet.Species}  |  {pet.Hunger}  |  {pet.Boredom}  |  {pet.Health}  |");
            }
            Console.WriteLine("\nRobot Pets:\n");
            foreach (var pet in listOfRobotPets)
            {
                Console.WriteLine($"|  {pet.Name}  |  {pet.Species}  |  {pet.Oil}  |  {pet.Boredom}  |  {pet.Performance}  |");
            }
        }

        public void Tick()
        {
            foreach (var pet in listOfOrganicPets)
            {
                pet.Boredom++;
                pet.Hunger++;
                pet.Health--;
            }
            foreach (var pet in listOfRobotPets)
            {
                pet.Oil++;
                pet.Performance--;
                pet.Boredom++;
            }
        }

        public void AdoptOrganic(OrganicPet organicPet)
        {
            listOfOrganicPets.Remove(organicPet);
        }
        public void AdoptRobot(RobotPet robotPet)
        {
            listOfRobotPets.Remove(robotPet);
        }

        // FeedAll method moved from the RobotPet and OrganicPet classes
        public void FeedAll()
        {
            foreach (var pet in this.listOfOrganicPets)
            {
                pet.Hunger--;
                Console.WriteLine($"{pet.Name} was fed kibble.");
            }

            foreach (var pet in this.listOfRobotPets)
            {
                pet.Oil--;
                Console.WriteLine($"{pet.Name} was given oil.");
            }
        }

        public void TakeToDoctorAll()
        {
            foreach (var pet in this.listOfOrganicPets)
            {
                pet.Health++;
                Console.WriteLine($"{pet.Name} was taken to the doctor.");
            }

            foreach (var pet in this.listOfRobotPets)
            {
                pet.Performance++;
                Console.WriteLine($"{pet.Name} was taken in for maintenance.");
            }
        }

        public void ExerciseAll()
        {
            foreach (var pet in this.listOfOrganicPets)
            {
                pet.Health++;
                pet.Hunger++;
                pet.Boredom--;
                Console.WriteLine($"{pet.Name} was taken out for exercise.");

            }

            foreach (var pet in this.listOfRobotPets)
            {
                pet.Performance++;
                pet.Oil++;
                pet.Boredom--;
                Console.WriteLine($"{pet.Name} was taken out for exercise.");

            }
        }
    }
}
