using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal abstract class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public void work()
        {
            Console.WriteLine("Person is working");
        }
    }

    internal class Teacher : Person
    {
        public void teach()
        {
            Console.WriteLine("Teacher is teaching");
        }
    }

    internal class Student : Person
    {
        public void study()
        {
            Console.WriteLine("Student is studying");
        }
    }
}
