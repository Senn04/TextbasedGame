using System;
using System.Collections.Generic;
using System.Text;

namespace TextBasedGame
{
    class Character : Entity
    {
        public static void createNewCharacter()
        {
            Console.WriteLine("Character created");
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
