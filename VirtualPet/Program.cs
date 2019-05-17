using System; 

namespace VirtualPet
{
   
    class Program
    {
        static void Main(string[] args)

        {
            string response = "";
            bool whilePlayingGame = true;

            do
            {
                Console.WriteLine("Please choose one of the following menu options.");
                Console.WriteLine("Type play or exit");
                response = Console.ReadLine().ToLower();

                switch (response)

                {
                    case "play":
                        Console.WriteLine("Let's play!!!!!");
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
