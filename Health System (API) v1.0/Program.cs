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

        }
        static int TakeDamage(int arm, int hp, int dmg, int stocks)
        {
            if (arm > 0)
            {
                arm = arm - dmg; //maybe broke, remember arm then hp
            }
            if (hp > 0)
            {
                hp = hp - dmg;
            }
            else
            {

            }
        }
    }
}
