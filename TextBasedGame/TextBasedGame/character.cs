using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedGame
{
    class Character : Entity
    {
        public static void createNewCharacter()
        {
            Console.WriteLine("Character created");
            
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


    }
}
