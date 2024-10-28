using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionPractise
{
    internal class Emplooyee: IEmplooyee//IEmplooyee interface'sini implemente ediyoruz.
    {
        
        public string name { get; set; }//property

        public string surname { get; set; }//   property

        public string department { get; set; }//property

        public string job { get; set; }//property


        public void getJob(string job)//Method
        {
            Console.WriteLine($"I'm working {job} position");
        }

        

        public void getInfo()//Method
        {
            Console.WriteLine($"My name is {this.name}");
            Console.WriteLine($"My surname is {this.surname}");
            Console.WriteLine($"My department is {this.department}");
        }
    }
}
