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
        //public OrganicPet AddPet()
        //{
        //    Console.WriteLine("Let's name the new pet in your shelter. What would you like to name your pet?");
        //    (this.Name) = Console.ReadLine();
        //    Console.WriteLine($"{this.Name} is a great name! What species is {this.Name}?");
        //    this.Species = Console.ReadLine();
        //    return this;
        //}
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
        public void FeedAll(Shelter shelter)
        {
            foreach (var pet in shelter.listOfOrganicPets)
                pet.Hunger--;

        }
        public void TakeToDoctorAll(Shelter shelter)
        {
            foreach (var pet in shelter.listOfOrganicPets)
                pet.Health++;
        }
        public void ExerciseAll(Shelter shelter)
        {
            foreach (var pet in shelter.listOfOrganicPets)
            {
                pet.Health++;
                pet.Hunger++;
                pet.Boredom--;
            }
        }
       
    }
}
