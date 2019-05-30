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
        public void FeedPet()
        {
            shelter.ChooseOrganicPet();
            Console.WriteLine($"{shelter.ChooseOrganicPet().Name}'s hunger level is now {shelter.ChooseOrganicPet().Hunger}");
        }


        public void TakeToDoctor()
        {
            shelter.ChooseOrganicPet();
            Console.WriteLine($"{shelter.ChooseOrganicPet().Name}'s health level is now {shelter.ChooseOrganicPet().Health}");
        }


        public void Exercise()
        {
            shelter.ChooseOrganicPet();

            shelter.ChooseOrganicPet().Health++;
            shelter.ChooseOrganicPet().Hunger++;
            shelter.ChooseOrganicPet().Boredom--;
            Console.WriteLine($"{shelter.ChooseOrganicPet().Name} now has {shelter.ChooseOrganicPet().Health} health, {shelter.ChooseOrganicPet().Hunger} hunger," +
                $" and {shelter.ChooseOrganicPet().Boredom} boredom.");
        }
    }
}
