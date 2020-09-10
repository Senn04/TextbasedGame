using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedGame
{
    class Character : Entity
    {
        
        public static int 
            health = 20, 
            stamina = 20,
            mana = 5,
            toughness = 0,
            damageMax = 4,
            damageMin = 2,
            dexterity = 2;

        public static void createNewCharacter()
        {
            Console.WriteLine("Character created");
            
            //Console.Clear();
            //Game.GameInfo();
            Combat.SetStats(health, stamina, mana, toughness, damageMax, damageMin, dexterity);
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
