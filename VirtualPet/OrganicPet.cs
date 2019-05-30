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

        public OrganicPet ChoosePet()
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
        public override void FeedPet()
        {
            ChoosePet();

            ChoosePet().Hunger--;
            Console.WriteLine($"{ChoosePet().Name}'s hunger level is now {ChoosePet().Hunger}");
        }
        public override void TakeToDoctor()
        {
            ChoosePet();

            ChoosePet().Health++;
            Console.WriteLine($"{ChoosePet().Name}'s health level is now {ChoosePet().Health}");
        }
        public override void Exercise()
        {
            ChoosePet();

            ChoosePet().Health++;
            ChoosePet().Hunger++;
            ChoosePet().Boredom--;
            Console.WriteLine($"{ChoosePet().Name} now has {ChoosePet().Health} health, {ChoosePet().Hunger} hunger," +
                $" and {ChoosePet().Boredom} boredom.");
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
