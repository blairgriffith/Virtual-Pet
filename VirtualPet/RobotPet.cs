using System;
using System.Collections.Generic;
using System.Text;

namespace OrganicPet
{
    class RobotPet : Pet 

    {
        public int Oil { get; set; }
        public int Performance { get; set; }
        Shelter shelter = new Shelter();

        public RobotPet() : base("", "")
        {
            Oil = 9;
            Performance = 10;
        }

        public RobotPet ChoosePet()
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
        public override void FeedPet()
        {
            ChoosePet();

            ChoosePet().Oil++;
            Console.WriteLine($"{ChoosePet().Name}'s oil level is now {ChoosePet().Oil}");
        }
        public override void TakeToDoctor()
        {
            ChoosePet();

            ChoosePet().Performance++;
            Console.WriteLine($"{ChoosePet().Name}'s performance level is now {ChoosePet().Performance}");
        }
        public override void Exercise()
        {
            ChoosePet();

            ChoosePet().Performance++;
            ChoosePet().Oil--;
            ChoosePet().Boredom--;
            Console.WriteLine($"{ChoosePet().Name} now has {ChoosePet().Performance} performance, {ChoosePet().Oil} oil," +
                $" and {ChoosePet().Boredom} boredom.");
        }

        //all robot pet methods
        public void FeedAll()
        {
            foreach (var pet in shelter.listOfRobotPets)
                pet.Oil--;

        }
        public void TakeToDoctorAll()
        {
            foreach (var pet in shelter.listOfRobotPets)
                pet.Performance++;
        }
        public void ExerciseAll()
        {
            foreach (var pet in shelter.listOfRobotPets)
            {
                pet.Performance++;
                pet.Oil++;
                pet.Boredom--;
            }
        }
        public void GetInfoAll()
        {
            foreach (var pet in shelter.listOfRobotPets)
                Console.WriteLine($"Your {pet.Species} is named {pet.Name}");
        }

    }
}
