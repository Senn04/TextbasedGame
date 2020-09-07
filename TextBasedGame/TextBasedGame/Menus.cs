using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TextBasedGame
{
    class Menus : Game
    {

        public static void GameMenu()
        {
            //Main menu options

            Console.WriteLine("Potato Entertainment Presents:");
            Console.WriteLine("  ### PlaceHolderName ###");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Press:");
            Console.WriteLine("   1 to start game");
            Console.WriteLine("   2 to load saved character");
            Console.WriteLine("   3 to quit the game");

            //Option choise
            string choiseStr = Console.ReadLine();
            _ = Convert.ToInt32(choiseStr);

        }

        public static void ActionMenu()
        {
            
        }
    }
}
