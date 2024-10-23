using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class GameCaracter
    {
        //freatures
        public string name;
        public int level;
        public int health;
        public int mana;
        public int damage;

        //methods
        public void greeting()
        {
            Console.WriteLine("Hello, I am a game caracter. My name is " + name + " and my level is " + level);
        }

        public void attack(GameCaracter target)
        {
            if (mana > 10)
            {
                Console.WriteLine("Attacking " + target.name + " with " + damage + " damage");
                mana -= 10;
                target.health -= this.damage;
                Console.WriteLine("Mana is now at " + mana);
                Console.WriteLine($"Target hp = {target.health}");
            }
            else
            {
                Console.WriteLine("Not enough mana to attack");
            }
        }

        public void heal(GameCaracter target,int heal)
        {
            if (mana > 0 && this.mana >= heal)
            {
                Console.WriteLine("Healing " + target.name + " with " + heal +" health");
                target.health += heal;
                mana -= heal;
                Console.WriteLine("Mana is now at " + mana);
            }
            else
            {
                Console.WriteLine("Not enough mana to heal");
            }
        }
    }
}
