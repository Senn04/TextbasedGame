using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedGame
{
    class Character
    {
        
        public static int 
            health = 20, 
            stamina = 20,
            mana = 5,
            toughness = 0,
            damageMax = 4,
            damageMin = 2,
            dexterity = 2;

        public static int[] statArray = new int[7] {health, stamina, mana, toughness, damageMax, damageMin, dexterity};

        


    }
}
