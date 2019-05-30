using System;
using System.Collections.Generic;
using System.Text;

namespace OrganicPet
{
    public class RobotPet : Pet 

    {
        public int Oil { get; set; }
        public int Performance { get; set; }
       

        public RobotPet() : base("", "")
        {
            Oil = 9;
            Performance = 10;
        }
        public RobotPet AddPet()
        {
           
            Console.WriteLine("Let's name the new pet in your shelter. What would you like to name your pet?");
            (this.Name) = Console.ReadLine();
            Console.WriteLine($"{this.Name} is a great name! What species is {this.Name}?");
            this.Species = Console.ReadLine();
            return this;
        }
        public RobotPet ChoosePet(Shelter shelter)
        {
            int i = 0;
            foreach (var pet in shelter.listOfRobotPets)
            {
                i = i + 1;
                Console.WriteLine($"{i}. {pet.Name}");
            }
            int choice = Convert.ToInt32(Console.ReadLine());
            choice--;
            Console.WriteLine($"You have chosen {shelter.listOfRobotPets[choice].Name}");
            return shelter.listOfRobotPets[choice];
        }

        //single robot pet methods
        public void FeedPet(RobotPet robotPet)
        {
            robotPet.Oil++;
            Console.WriteLine($"{robotPet.Name}'s oil level is now {robotPet.Oil}");
        }
        public void TakeToDoctor(RobotPet robotPet)
        {
            robotPet.Performance++;
            Console.WriteLine($"{robotPet.Name}'s performance level is now {robotPet.Performance}");
        }
        public void Exercise(RobotPet robotPet)
        {
            robotPet.Performance++;
            robotPet.Oil--;
            robotPet.Boredom--;
            Console.WriteLine($"{robotPet.Name} now has {robotPet.Performance} performance, {robotPet.Oil} oil," +
                $" and {robotPet.Boredom} boredom.");
        }

        //all robot pet methods
        public void FeedAll(Shelter shelter)
        {
            foreach (var pet in shelter.listOfRobotPets)
                pet.Oil--;

        }
        public void TakeToDoctorAll(Shelter shelter)
        {
            foreach (var pet in shelter.listOfRobotPets)
                pet.Performance++;
        }
        public void ExerciseAll(Shelter shelter)
        {
            foreach (var pet in shelter.listOfRobotPets)
            {
                pet.Performance++;
                pet.Oil++;
                pet.Boredom--;
            }
        }
     }
}
