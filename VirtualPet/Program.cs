using System; 

namespace VirtualPet
{
   
    class Program
    {
        
        static void Main(string[] args)

        {
            VirtualPet first = new VirtualPet("", "");
            string response = "";
            bool whilePlayingGame = true;
            
            //Menu - should eventually be its own class?
            do
            {
                Console.WriteLine("Please choose one of the following menu options.");
                Console.WriteLine("Type play or exit");
                response = Console.ReadLine().ToLower();

                switch (response)

                {
                    case "play":
                        Console.WriteLine("Let's play!!!!!");
                        Console.WriteLine("Let's name your first pet");
                        first.Name = Console.ReadLine();
                        Console.WriteLine($"{first.Name} is a great name! What species is {first.Name}?");
                        first.Species = Console.ReadLine();
                        Console.WriteLine(first.Species);
                        break;
                    case "exit":
                        Console.WriteLine("Thank you for playing!");
                        whilePlayingGame = false;
                        break;
                    default:
                        Console.WriteLine("Invalid entry. Please try again.");
                        break;
                }
            } while (whilePlayingGame);

            
        }
    }
}
