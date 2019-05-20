using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    static class Menu
    {
        static public void GameplayMenu()
        {
            {
            
            switch (response)
            {
                case "pet info":
                    VirtualPet.GetInfo();
                    break;
                case "pet status":
                    VirtualPet.GetStatus();
                    break;
                case "feed pet":
                    VirtualPet.FeedPet();
                    Console.WriteLine($"Your pet's hunger level is now {Hunger}");
                    break;
                default:
                    Console.WriteLine("command not recognized");
                    break;
            }
        }
    }
}
