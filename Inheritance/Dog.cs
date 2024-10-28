using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Dog:Animal
    {
       public override void makeSound()//makeSound metodu Animal sınıfında abstract olarak tanımlanmıştır. Bu metot Dog sınıfında override edilmiştir.
        {
            Console.WriteLine("Dog is making sound");
        }

    }
}
