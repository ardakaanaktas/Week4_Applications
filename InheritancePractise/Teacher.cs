using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractise
{
    internal class Teacher:Person
    {
        public int salary { get; set; }

        public override void getInfo()//override keyword is used to override the method in the base class
        {
            base.getInfo();//base keyword is used to call the base class method
            Console.WriteLine("Salary : " + salary);//this keyword is used to refer to the current instance of the class
        }
    }
}
