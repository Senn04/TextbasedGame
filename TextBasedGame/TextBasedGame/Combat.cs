using System;
using System.Collections.Generic;
using System.Text;

namespace TextBasedGame
{
    class Combat
    {
        public static Character character = new Character();

        //player + stat is a temporary name
        public static int
            playerHealth,
            playerStamina,
            playerMana,
            playerToughness,
            playerDamageMax,
            playerDamageMin,
            playerDexterity;


        public static void testFunction()
        {
            Console.WriteLine();
        }

        public void inCombat ()
        {
            //Set stats
            int enemHp = 50;
            int attack = 5;
            int enemAttack = 3;
            int enemySCountdown = 5;
            bool anyAlive = true;

            //Opens a "new" window with default text in the top
            Console.Clear();
            Game.GameInfo();

            Console.WriteLine("Welcome to arr pee gee V0.00000001");
            Console.WriteLine("Get ready to fight!");

            Console.ReadKey();

            Console.Clear();
            Game.GameInfo();

            //These scripts will repeat until either player hp or enemy hp reaches 0 or less
            while (anyAlive)
            {
                //Status message every in beginning of turn
                Console.WriteLine("Hp: " + playerHealth);
                Console.WriteLine("Enemy Hp: " + enemHp);
                Console.WriteLine("   ");
                Console.WriteLine("What will you do?");
                Console.WriteLine("    1 Attack");
                Console.WriteLine("    2 Block");
                Console.WriteLine("    3 Heal");

                //Option choise
                string choiseStr = Console.ReadLine();
                int choise = Convert.ToInt32(choiseStr);

                Console.Clear();
                Game.GameInfo();

                if (choise == 1)
                    {
                        //Attacks enemy by subtracting attack from enemy hp
                        Console.WriteLine("You attacked!");
                        Console.WriteLine("Dealt " + attack + " damage to enemy!");
                        enemHp -= attack;
                }
                else if (choise == 2)
                    {
                        //Blocks and halves enemy damage for one turn
                        Console.WriteLine("You block! You will take half damage if attacked!");
                }
                else if (choise == 3)
                {
                    //Heals you by giving you 5 hp
                    Console.WriteLine("You healed yourself!");
                    Console.WriteLine("You got 7 hp!");
                    playerHealth += 7;
                }
                else
                    {
                     //If no matching string was found
                     Console.WriteLine("You did nothing");
                }

                 Console.ReadLine();

                //Enemy's turn

                Console.WriteLine("Enemy turn!");
                Console.WriteLine("Enemy attacked!");

                //Checks if enemy is dead so it can't attack you
                if (enemHp < 1)
                {
                    Console.WriteLine("But enemy is dead!");
                }
                else
                {
                    if (enemySCountdown == 0)
                    {
                        Console.WriteLine("Special attack!");
                        Console.WriteLine("You lost " + enemAttack * 3 + " hp!");
                        playerHealth -= enemAttack * 3;
                        enemySCountdown = 5;
                    }
                    else if (enemySCountdown == 1)
                    {
                        Console.WriteLine("Enemy is prepairing for something...");
                        enemySCountdown -= 1;
                    }
                    else
                    {
                        Console.WriteLine("You lost " + enemAttack + " hp!");
                        playerHealth -= enemAttack;
                        enemySCountdown -= 1;
                    }
                }

                Console.ReadKey();

                Console.WriteLine("   ");

                //Checks if someone died
                if (playerHealth <= 0 || enemHp <= 0)
                {
                    anyAlive = false;
                }

            }

            Console.Clear();

            if (playerHealth <= 0)
            {
                Console.WriteLine("You lost...");
            }
            else if (enemHp <= 0)
            {
                Console.WriteLine("You Won!");
            }

            Console.ReadLine();
        }

    }
}
