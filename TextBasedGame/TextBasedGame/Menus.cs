using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TextBasedGame
{
    class Menus : Game
    {

        public static async void GameMenu()
        {
            //Main menu options

            Game.GameInfo();
            Console.WriteLine("Press:");
            Console.WriteLine("   1 to start game");
            Console.WriteLine("   2 to see studio info");
            Console.WriteLine("   3 to quit the game");

            //Option choice
            string choiceStr = Console.ReadLine();
            int choice = Convert.ToInt32(choiceStr);

            //Using the 
            if (choice == 1)
            {
                Console.Clear();
                Game.GameInfo();
                Menus.characterOptionMenu();
            }
            else if (choice == 2)
            {

            }
            else if (choice == 3)
            {
                SentryTools.Quit();
            }
            else
            {
                Console.WriteLine("That's not a valid option.");
                Console.WriteLine("Please select a valid option");
                await Task.Delay(800);
                Console.Clear();
                Menus.GameMenu();
            }
        }

        public static void characterOptionMenu()
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
                Menus.createNewCharacter();


            }
        }

        public static void createNewCharacter()
        {
            Console.WriteLine("Character created");
            SentryTools.LoadingBar(6, 100);
            Thread.Sleep(1300);

            Console.Clear();
            Game.GameInfo();
            Menus.ActionMenu();
            
        }

        public static void saveCharacterState()
        {
            Console.WriteLine("Character saved");
        }

        public static void loadSavedCharacter()
        {
            Console.WriteLine("CharacterLoaded");
        }
        public static void ActionMenu()
        {
            Console.WriteLine("Choose an action to make:");
            Console.WriteLine("    1 Travel");
            Console.WriteLine("    2 Train");
            Console.WriteLine("    3 Rest");
            Console.WriteLine(" ");
            Console.WriteLine("    4 Quit");

            //Option choice
            string choiceStr = Console.ReadLine();
            int choice = Convert.ToInt32(choiceStr);

            if (choice == 1)
            {
                SentryTools.LoadingBar(12, 80);
                Thread.Sleep(970);
                Console.Clear();
                Game.GameInfo();
                Menus.TravelMenu();
            }
            else if (choice == 2)
            {

            }
            else if (choice == 3)
            {

            }
            else if (choice == 4)
            {
                Console.WriteLine("Are you sure you want to quit? [y/n]");
                string choiceStrL = Console.ReadLine();
                if (choiceStrL == "y")
                {
                    SentryTools.Quit();
                }
                else
                {
                    Console.Clear();
                    Game.GameInfo();
                    Menus.ActionMenu();
                }
            }
            else
            {

            }        
        }
        public static void TravelMenu()
        {
            Console.WriteLine("Travel comming soon, you'll now be returned to the actions menu");
            Thread.Sleep(1200);
            Console.Clear();
            Game.GameInfo();
            Menus.ActionMenu();
        }
    }
}
