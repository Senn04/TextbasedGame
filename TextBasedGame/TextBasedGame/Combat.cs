using System;
using System.Collections.Generic;
using System.Text;

namespace TextBasedGame
{
    class Combat : Character
    {

        //player + stat is a temporary name
        public int
            playerHealth,
            playerStamina,
            playerMana,
            playerToughness,
            playerDamageMax,
            playerDamageMin,
            playerDexterity;

        /*
        //Set stats
        int hp = 20;
        int enemHp = 50;
        int attack = 5;
        int enemAttack = 3;
        int enemySCountdown = 5;
        bool anyAlive = true;

        Console.WriteLine("Welcome to arr pee gee V0.00000001");
            Console.WriteLine("Get ready to fight!");

            Console.ReadKey();
            Console.Clear();

            //These scripts will repeat until either player hp or enemy hp reaches 0 or less
            while (anyAlive)
            {
                //Status message every in beginning of turn
                Console.WriteLine("Hp: " + hp);
                Console.WriteLine("Enemy Hp: " + enemHp);
                Console.WriteLine("   ");
                Console.WriteLine("What will you do?");
                Console.WriteLine("   ");
                Console.WriteLine("Attack");
                Console.WriteLine("Block");
                Console.WriteLine("Heal");

                //Reads command by player
                string input = Console.ReadLine();

        Console.Clear();
                
                if (input == "Attack")
                {
                    //Attacks enemy by subtracting attack from enemy hp
                    Console.WriteLine("You attacked!");
                    Console.WriteLine("Dealt " + attack + " damage to enemy!");
                    enemHp -= attack;
                }
                else if (input == "Block")
                {
                    //Blocks and halves enemy damage for one turn but it's not programmed in yet
                    Console.WriteLine("You block! You will take half damage if attacked!");
                }
                else if (input == "Heal")
                {
                    //Heals you by giving you 5 hp
                    Console.WriteLine("You healed yourself!");
                    Console.WriteLine("You got 7 hp!");
                    hp += 7;
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
                if (enemHp< 1)
                {
                    Console.WriteLine("But enemy is dead!");
                }
                else
                {
                    if (enemySCountdown == 0)
                    {
                        Console.WriteLine("Special attack!");
                        Console.WriteLine("You lost " + enemAttack* 3 + " hp!");
                        hp -= enemAttack* 3;
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
                        hp -= enemAttack;
                        enemySCountdown -= 1;
                    }
                }

                Console.ReadKey();

                Console.WriteLine("   ");

                //Checks if someone died
                if (hp <= 0 || enemHp <= 0)
                {
                    anyAlive = false;
                }
                
            }

            Console.Clear();

            if (hp <= 0)
            {
                Console.WriteLine("You lost...");
            }
            else if (enemHp <= 0)
            {
                Console.WriteLine("You Won!");
            }

            Console.ReadLine();
            */

    }
}
