using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Cat: Animal//Cat sınıfı Animal sınıfından türetilmiştir.
    {

        public override void makeSound()//makeSound metodu Animal sınıfında abstract olarak tanımlanmıştır. Bu metot Cat sınıfında override edilmiştir.
        {
            Console.WriteLine("Cat is making sound");
        }
    }
}
