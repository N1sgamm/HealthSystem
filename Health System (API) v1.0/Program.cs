using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_System__API__v1._0
{
    internal class Program
    {
        //initialization
        static int health;
        static string healthStatus;
        static int shield;
        static int lives;
        static int monsters;
        static void Main(string[] args)
        {
            health = 100;
            healthStatus = "You are at full health.";
            shield = 100;
            lives = 3;
            monsters = 3;

            Console.WriteLine("Health System");
            Console.WriteLine("by Zackery Goodwin");
            Console.WriteLine("-----------------------");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey(true);
            Console.Clear();
            ShowHUD();
            Console.WriteLine("Press any button to kill a monster");
            Console.ReadKey(true);
            Console.Clear();

            TakeDamage(monsters * 10);
            Console.ReadKey(true);
            Console.Clear();

            TakeDamage(monsters * 10);
            Console.ReadKey(true);
            Console.Clear();

            TakeDamage(monsters * 10);
            Console.ReadKey(true);
            Console.Clear();

            TakeDamage(monsters * 10);
            Console.ReadKey(true);
            Console.Clear();
        }
        static void Heal(int hp)
        {

        }
        static void ShowHUD()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Current Shield Points: " + shield);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Current Health Points: " + health);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Current Number of Lives: " + lives);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Current Number of Monsters: " + monsters);
            Console.WriteLine("-----------------------------");
            Console.WriteLine();
        }
        static void OneUp()
        {
            lives = lives - 1;
            health = 100;
            shield = 100;
        }
        static void GameOver()
        {

        }
        static void TakeDamage(int damage)
        {
            if (damage < 0)
            {
                Console.WriteLine("Error: damage can not be less than 0");
            }
            else if (shield >= damage)
            {
                shield = shield - damage;
                ShowHUD();
            }
            else
            {
                damage = damage - shield;
                shield = shield - shield;
                health = health - damage;
                if (health <= 0)
                {
                    OneUp();
                    if (lives <= 0)
                    {
                        GameOver();
                    }

                }
                else
                {
                    ShowHUD();
                }
            }
        }
        static void ShowHealthStatus()
        {
            if (health == 100)
            {
                healthStatus = "You are at full health";
            }

        }
    }
}
