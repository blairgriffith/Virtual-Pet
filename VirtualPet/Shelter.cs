using System;
using System.Collections.Generic;
using System.Text;

namespace OrganicPet
{
    class Shelter
    {
        OrganicPet organicPet = new OrganicPet();
        RobotPet robotPet = new RobotPet();
        public List<Pet> listOfAllPets = new List<Pet>();
        public List<OrganicPet> listOfOrganicPets = new List<OrganicPet>();
        public List<RobotPet> listOfRobotPets = new List<RobotPet>();
        int choice;

        //add pets to appropriate lists
        public void AddOrganicPetToShelter()
        {
            organicPet.AddPet();
            listOfAllPets.Add(organicPet);
        }
        public void AddRobotPetToShelter()
        {
            robotPet.AddPet();
            listOfAllPets.Add(robotPet);
        }

        //methods to choose pet from specific list
        public OrganicPet ChooseOrganicPet()
        {
            int i = 0;
            foreach (var pet in listOfOrganicPets)
            {
                i = i + 1;
                Console.WriteLine($"{i}. {pet.Name}");
            }
            int choice = Convert.ToInt32(Console.ReadLine());
            choice--;
            Console.WriteLine($"You have chosen {listOfOrganicPets[choice].Name}");
            return listOfOrganicPets[choice];
        }

        public RobotPet ChooseRobotPet()
        {
            int i = 0;
            foreach (var pet in listOfRobotPets)
            {
                i = i + 1;
                Console.WriteLine($"{i}. {pet.Name}");
            }
            int choice = Convert.ToInt32(Console.ReadLine());
            choice--;
            Console.WriteLine($"You have chosen {listOfRobotPets[choice].Name}");
            return listOfRobotPets[choice];
        }

        //methods for all pets
        public void GetStatusAll()
        {
            Console.WriteLine("|Name        | Hunger/Oil | Boredom  | Health/Performance |");
            Console.WriteLine("|------------|------------|----------|--------------------|");

            foreach(var shelterPet in listOfOrganicPets)
            {
                Console.WriteLine($"| {shelterPet.Name} | {shelterPet.Hunger} | {shelterPet.Boredom} | {shelterPet.Health}|");
            }
            foreach (var pet in listOfRobotPets)
            {
                Console.WriteLine($"| {pet.Name} | {pet.Oil} | {pet.Boredom} | {pet.Performance}|");
            }
        }
        //organic pet methods
        public void FeedAll()
        {
            foreach (var pet in listOfOrganicPets)
                pet.Hunger--;

        }
        public void TakeToDoctorAll()
        {
            foreach (var pet in listOfOrganicPets)
                pet.Health++;
        }
        public void ExerciseAll()
        {
            foreach (var pet in listOfOrganicPets)
            {
                pet.Health++;
                pet.Hunger++;
                pet.Boredom--;
            }
        }
        public void GetInfoAll()
        {
            foreach (var pet in listOfOrganicPets)
                Console.WriteLine($"Your {pet.Species} is named {pet.Name}");
        }

        //robot pet methods
        public void OilAll()
        {
            foreach (var pet in listOfOrganicPets)
                pet.Oil--;

        }
        public void TakeToMechanicAll()
        {
            foreach (var pet in listOfOrganicPets)
                pet.Performance++;
        }
        public void PilotAll()
        {
            foreach (var pet in listOfOrganicPets)
            {
                pet.Peformance++;
                pet.Oil++;
                pet.Boredom--;
            }
        }
        public void GetInfoAll()
        {
            foreach (var pet in listOfOrganicPets)
                Console.WriteLine($"Your {pet.Species} is named {pet.Name}");
        }
        // methods for single pet
        public void GetInfo()
        {
            Console.WriteLine($"Your {listOfPets[choice].Species} is named {listOfPets[choice].Name}");
        }
        public void GetStatus()
        {
            Console.WriteLine($"{listOfPets[choice].Name} has {listOfPets[choice].Hunger} hunger, {listOfPets[choice].Boredom} boredom, " +
                $"and {listOfPets[choice].Health} health.");
        }
    }


}
