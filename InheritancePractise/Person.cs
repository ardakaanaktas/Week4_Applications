using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractise
{
    internal class Person
    {
        public string Name { get; set; }// auto-implemented property
        public string Surname { get; set; }// auto-implemented property

        public virtual void getInfo() // virtual keyword is used to override this method in derived classes
        {
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Surname : " + Surname);
        }
    }
}
