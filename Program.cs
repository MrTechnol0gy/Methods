using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Methods
{
    internal class Program
    {
        static int score; //stores the player's total score over time
        static int enemyScoreValue;
        static int playerHealth;
        static int enemyDamage;
        static int combomultiplier;
        static int currentscore; //stores the score for the shot the player is currently making
        static void Main(string[] args)
        {
            score = 0;
            enemyScoreValue = 100;
            playerHealth = 100;
            enemyDamage = 25;
            combomultiplier = 1;

            Console.WriteLine();
            Console.WriteLine("Earn 1000 points to beat the bandits, but lose all your hit points and you'll die!");
            Console.WriteLine("Good luck, partner!");
            Console.WriteLine();

            Thread.Sleep(3000);
            Console.Clear();
                        
            while (playerHealth > 0 && score < 1000) //loops the main game content while the player is alive and under a certain score
            {
                ShowHud(); //calls the showhud method
                PlayerChoice();  //calls the playerchoice method
                Thread.Sleep(1000); //waits after displaying results from the player choice
                Console.Clear(); //clears the console in preparation for displaying the hud again
            }
            if (score >= 1000)
            {
            Console.WriteLine();
            Console.WriteLine("You've beaten the bandits and won the day!");
            Thread.Sleep(3000);
            }

        }

        static void ShowHud()
        {
            Console.WriteLine("Bandit Showdown.");
            Console.WriteLine();
            Console.WriteLine("===========================");
            Console.WriteLine("= Player Health: " + playerHealth);
            Console.WriteLine("= Score: " + score);
            Console.WriteLine("===========================");
            Console.WriteLine();            
        }

        static void PlayerChoice()
        {
            
            Console.WriteLine("Press 'F' to shoot, or any other key to get shot!");                        
            if (Console.ReadKey().Key == ConsoleKey.F)
            {
                Console.WriteLine();
                Console.WriteLine("You've shot the enemy!");
                combomultiplier++;
                score = score + enemyScoreValue * combomultiplier;
                currentscore = enemyScoreValue * combomultiplier;
                Console.WriteLine("You've earned " + currentscore + " points!");
                return;
            }
            else //if (Console.ReadKey().Key == ConsoleKey.J)
            {
                Console.WriteLine();
                Console.WriteLine("You've been shot!");
                combomultiplier = 1;
                playerHealth = playerHealth - enemyDamage;
                Console.WriteLine("You take " + enemyDamage + " damage!");
                if (playerHealth <= 0)
                {
                    Console.WriteLine("You have died!");                    
                }                
            return;
            }        
        }
    }
}
