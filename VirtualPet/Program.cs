using System; 

namespace VirtualPet
{
   
    class Program
    {
        
        static void Main(string[] args)

        {
            Shelter ProgramShelter = new Shelter();
            Menu ProgramMenu = new Menu();
            ProgramShelter.AddPetToShelter();
        }
    }
}
