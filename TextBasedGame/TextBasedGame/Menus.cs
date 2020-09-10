﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Metadata;
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

            //Option choice
            string choiceStr = Console.ReadLine();
            int choice = Convert.ToInt32(choiceStr);

            //Using the 
            if (choice == 1)
            {
                Console.Clear();
                Game.GameInfo();
                Menus.characterMenu();
            }
            else if (choice == 2)
            {

            }
            else
            {

            }
        }

        public static void characterMenu()
        {
            Console.WriteLine("Choose do you want to create or load character?");
            Console.WriteLine("    1 Create new character");
            Console.WriteLine("    2 Load a saved character");

            //Option choice
            string choiceStr = Console.ReadLine();
            int choice = Convert.ToInt32(choiceStr);

            if (choice == 1)
            {
                Console.Clear();
                Game.GameInfo();
                Character.createNewCharacter();


            }
        }
        
        public static void ActionMenu()
        {
            Console.WriteLine("Choose an action to make:");
            Console.WriteLine("    1 Travel");
            Console.WriteLine("    2 Train");
            Console.WriteLine("    3 Rest");
            Console.WriteLine(" ");
            Console.WriteLine("    4 Quit");
        }
    }
}
