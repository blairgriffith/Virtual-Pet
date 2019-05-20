using System; 

namespace VirtualPet
{
   
    class Program
    {
        
        static void Main(string[] args)

        {
            VirtualPet first = new VirtualPet("", "", 5,6,7);
            VirtualPet second = new VirtualPet();
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
                        Console.WriteLine("Type \"pet info\" to view the name and species of your pet \nor type \"pet status\" to view levels");
                        response = Console.ReadLine().ToLower();
                        switch (response)
                        {
                            case "pet info":
                                Console.WriteLine($"My name is {first.Name} and I am a {first.Species}.");
                                break;

                            case "pet status":
                                Console.WriteLine($" I have {first.Hunger} and I have {first.Boredom} and I have {first.Health}");
                                break;
                            default:
                         
                                Console.WriteLine("command not recognized");
                                break;
                        }
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
