using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
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
                Environment.Exit(0);
                return;
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

        public static async void createNewCharacter()
        {
            Console.WriteLine("Character created");
            Game.LoadingBar(6);
            await Task.Delay(1300);

            Console.Clear();
            Game.GameInfo();
            
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
        }
    }
}
