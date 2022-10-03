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
        static void Main(string[] args)
        {
            score = 0;
            enemyScoreValue = 100;
            playerHealth = 100;
            enemyDamage = 25;
            
            Console.WriteLine("Methods.");

            ShowHud();

            Console.WriteLine("Press any key to quit.");
            Console.ReadKey(true);
        }

        static void ShowHud()
        {
            PlayerChoice();
            Console.WriteLine("===========================");
            Console.WriteLine("Score: " + score);
            Console.WriteLine("===========================");
            Console.WriteLine();
            score = score + enemyScoreValue;
            Console.WriteLine("===========================");
            Console.WriteLine("Score: " + score);
            Console.WriteLine("===========================");
        }

        static void PlayerChoice()
        {

            Console.WriteLine("Press 'F' to shoot, or Press 'J' to get shot!");
            Console.WriteLine("Press any other key to exit the game.");
            if (Console.ReadKey().Key == ConsoleKey.F)
            {
                Console.WriteLine("You've shot the enemy!");                
            }
            else if (Console.ReadKey().Key == ConsoleKey.J)
            {
                Console.WriteLine("You've been shot!");
            }    
            else
            {
                Console.ReadKey(true);
            }

        }
    }
}
