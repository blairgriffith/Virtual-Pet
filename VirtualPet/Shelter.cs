using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    class Shelter
    {
        VirtualPet shelterPet = new VirtualPet("", "");
        public List<VirtualPet> listOfPets = new List<VirtualPet>();

        public void AddPetToShelter()
        {
            shelterPet.AddPet();
            listOfPets.Add(shelterPet);
            shelterPet = new VirtualPet("","");
            
        }

        public void GetStatus()
        {
            Console.WriteLine("|Name        | Hunger | Boredom  | Health |");
            Console.WriteLine("|------------|--------|----------|--------|");

            foreach(var shelterPet in listOfPets)
            {
                Console.WriteLine($"| {shelterPet.Name} | {shelterPet.Hunger} | {shelterPet.Boredom} | {shelterPet.Health}|");

            }

        }
        public void ChoosePet()
        {
            int i = 0;
            foreach (var pet in listOfPets)
            {
                i = i + 1;
                Console.WriteLine($"{i}. {pet.Name}");
            }

            Console.ReadLine();

        }


        public void FeedAll()
        {
            foreach (var pet in listOfPets)
            {
                pet.FeedPet();
            }

        }
        public void TakeToDoctorAll()
        { foreach (var pet in listOfPets)
                pet.TakeToDoctor();

        }
        public void ExerciseAll()
        {
            foreach (var pet in listOfPets)
                pet.Exercise();
        }
        public void GetStatusAll()
        {
            foreach (var pet in listOfPets)
                pet.GetStatus();
        }
        public void GetInfoAll()
        {
            foreach (var pet in listOfPets)
                pet.GetInfo();
        }

    }


}
