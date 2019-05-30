using System;
using System.Collections.Generic;
using System.Text;

namespace OrganicPet
{
    public class OrganicPet : Pet
    {
        public int Hunger { get; set; }
        public int Health { get; set; }
        Shelter shelter = new Shelter();

        public OrganicPet() : base("", "")
        {
            Hunger = 7;
            Health = 6;
        }

        public OrganicPet ChoosePet(Shelter shelter)
        {
            int i = 0;
            foreach (var pet in shelter.listOfOrganicPets)
            {
                i = i + 1;
                Console.WriteLine($"{i}. {pet.Name}");
            }
            int choice = Convert.ToInt32(Console.ReadLine());
            choice--;
            Console.WriteLine($"You have chosen {shelter.listOfOrganicPets[choice].Name}");
            return shelter.listOfOrganicPets[choice];
        }

        //single organic pet methods
        public void FeedPet(OrganicPet organicPet)
        {
            organicPet.Hunger--;
            Console.WriteLine($"{organicPet.Name}'s hunger level is now {organicPet.Hunger}");
        }
        public void TakeToDoctor(OrganicPet organicPet)
        {
            organicPet.Health++;
            Console.WriteLine($"{organicPet.Name}'s health level is now {organicPet.Health}");
        }
        public void Exercise(OrganicPet organicPet)
        {
            organicPet.Health++;
            organicPet.Hunger++;
            organicPet.Boredom--;
            Console.WriteLine($"{organicPet.Name} now has {organicPet.Health} health, {organicPet.Hunger} hunger," +
                $" and {organicPet.Boredom} boredom.");
        }
        
        //all organic pet methods
        public void FeedAll()
        {
            foreach (var pet in shelter.listOfOrganicPets)
                pet.Hunger--;

        }
        public void TakeToDoctorAll()
        {
            foreach (var pet in shelter.listOfOrganicPets)
                pet.Health++;
        }
        public void ExerciseAll()
        {
            foreach (var pet in shelter.listOfOrganicPets)
            {
                pet.Health++;
                pet.Hunger++;
                pet.Boredom--;
            }
        }
        public void GetInfoAll()
        {
            foreach (var pet in shelter.listOfOrganicPets)
                Console.WriteLine($"Your {pet.Species} is named {pet.Name}");
        }
    }
}
