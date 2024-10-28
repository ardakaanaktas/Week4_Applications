using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal abstract class Animal
    {

        public void eat()
        {
            Console.WriteLine("Animal is eating");
        }

        public void sleep()
        {
            Console.WriteLine("Animal is sleeping");
        }

        public abstract void makeSound();
    }
}
