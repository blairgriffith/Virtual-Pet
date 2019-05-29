using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    class Shelter
    {
        VirtualPet shelterPet = new VirtualPet();
        public List<VirtualPet> listOfPets = new List<VirtualPet>();
        int choice;

        public void AddPetToShelter()
        {
            shelterPet.AddPet();
            listOfPets.Add(shelterPet);
            shelterPet = new VirtualPet();
            
        }

        public void GetStatusAll()
        {
            Console.WriteLine("|Name        | Hunger | Boredom  | Health |");
            Console.WriteLine("|------------|--------|----------|--------|");

            foreach(var shelterPet in listOfPets)
            {
                Console.WriteLine($"| {shelterPet.Name} | {shelterPet.Hunger} | {shelterPet.Boredom} | {shelterPet.Health}|");

            }

        }

        public int ChoosePet()
        {
            int i = 0;
            foreach (var pet in listOfPets)
            {
                i = i + 1;
                Console.WriteLine($"{i}. {pet.Name}");
            }
            int choice = Convert.ToInt32(Console.ReadLine());
            choice--;
            Console.WriteLine($"You have chosen {listOfPets[choice].Name}");
            return choice;
        }

        //methods for all pets

        public void FeedAll()
        {
            foreach (var pet in listOfPets)
                pet.Hunger--;

        }
        public void TakeToDoctorAll()
        {
            foreach (var pet in listOfPets)
                pet.Health++;
        }
        public void ExerciseAll()
        {
            foreach (var pet in listOfPets)
            {
                pet.Health++;
                pet.Hunger++;
                pet.Boredom--;
            }
        }
        public void GetInfoAll()
        {
            foreach (var pet in listOfPets)
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

        public void FeedPet()
        {
            listOfPets[choice].Hunger--;
            Console.WriteLine($"{listOfPets[choice].Name}'s hunger level is now {listOfPets[choice].Hunger}");
        }


        public void TakeToDoctor()
        {
            listOfPets[choice].Health++;
            Console.WriteLine($"{listOfPets[choice].Name}'s health level is now {listOfPets[choice].Health}");
        }


        public void Exercise()
        {
            listOfPets[choice].Health++;
            listOfPets[choice].Hunger++;
            listOfPets[choice].Boredom--;
            Console.WriteLine($"{listOfPets[choice].Name} now has {listOfPets[choice].Health} health, {listOfPets[choice].Hunger} hunger," +
                $" and {listOfPets[choice].Boredom} boredom.");
        }

    }


}
