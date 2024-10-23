using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    internal class Person
    {
        private string name;
        private string surname;
        private DateTime birthDate;

        public string Name  //property
        {
            get { return name; } //getter
            set { name = value; } //setter
        }

        public string Surname //property
        {
            get { return surname; } //getter
            set { surname = value; } //setter
        }

        public DateTime BirthDate //property
        {
            get { return birthDate; } //getter
            set { birthDate = value; } //setter
        }
    }
}
