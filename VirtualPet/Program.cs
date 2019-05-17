using System; 

namespace VirtualPet
{
    class VirtualPet
    {

    }
    class Program
    {
        static void Main(string[] args)

        {
            string response = "";

                Console.WriteLine("Please choose one of the following menu options.");
            Console.WriteLine("Type play or exit");
            response = Console.ReadLine().ToLower();

            
            switch (response)

            {
                case "play":
                    break;
                case "exit":
                    Console.WriteLine("Thank you for playing!");
                    break;


            }

            
        }
    }
}
