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

            Game.GameInfo();
            Console.WriteLine("Press:");
            Console.WriteLine("   1 to start game");
            Console.WriteLine("   2 to load saved character");
            Console.WriteLine("   3 to quit the game");

            //Option choise
            string choiseStr = Console.ReadLine();
            int choise = Convert.ToInt32(choiseStr);

            //Using the 
            if (choise == 1)
            {
                Console.Clear();
                Game.GameInfo();
                Menus.ActionMenu();
            }
            else if (choise == 2)
            {

            }
            else
            {

            }
        }

        public static void ActionMenu()
        {
            
        }
    }
}
