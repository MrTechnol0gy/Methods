using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static int score;
        static int enemyScoreValue;
        static int playerHealth;
        static int enemyDamage;
        static int combomultiplier;
        static void Main(string[] args)
        {
            score = 0;
            enemyScoreValue = 100;
            playerHealth = 100;
            enemyDamage = 25;
            combomultiplier = 1;
            
            Console.WriteLine("Methods.");

            while (playerHealth > 0)
            {
                ShowHud();
                PlayerChoice();        
            }

        }

        static void ShowHud()
        {
            Console.WriteLine("===========================");
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Player Health: " + playerHealth);
            Console.WriteLine("===========================");
            Console.WriteLine();            
        }

        static void PlayerChoice()
        {
            
            Console.WriteLine("Press 'F' to shoot, or Press 'J' to get shot!");                        
            if (Console.ReadKey().Key == ConsoleKey.F)
            {
                Console.WriteLine();
                Console.WriteLine("You've shot the enemy!");
                combomultiplier++;
                score = score + enemyScoreValue * combomultiplier;
                return;
            }
            else if (Console.ReadKey().Key == ConsoleKey.J)
            {
                Console.WriteLine();
                Console.WriteLine("You've been shot!");
                combomultiplier = 1;
                playerHealth = playerHealth - enemyDamage;                
                if (playerHealth <= 0)
                {
                    Console.WriteLine("You have died!");
                    return;
                }                
            return;
            }
        return;
        }
    }
}
