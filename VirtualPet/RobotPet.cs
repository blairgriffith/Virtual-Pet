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

        public void OilAll()
        {
            foreach (var pet in shelter.listOfRobotPets)
                pet.Oil--;

        }
        public void TakeToMechanicAll()
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
