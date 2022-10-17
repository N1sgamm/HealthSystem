using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_System__API__v1._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //initialization
            int health;
            int shield;
            int lives;
            int damage;
            int currentMonsters;
            health = 100;
            shield = 100;
            lives = 3;
            damage = currentMonsters * 10;

            //
            TakeDamage(shield, health, damage, lives);
        }
        static int ShowHUD()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Current Shield Points: " + shield);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Current Health Points: " + health);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Current Number of Lives: " + lives);
            Console.WriteLine("-----------------------------");

        }
        static int TakeDamage(int arm, int hp, int dmg, int stocks) // arm is shield, hp is health, stocks is lives
        {
            if (arm > dmg)
            {
                arm = arm - dmg;
            }
            else
            {
                dmg = dmg - arm;
                arm = arm - arm;
                hp = hp - dmg;
                if (hp <= 0)
                {
                    stocks = stocks - 1;
                    if (stocks <= 0)
                    {
                        GameOver; // Implement Game Over
                    }

                }
            }
        }
    }
}
