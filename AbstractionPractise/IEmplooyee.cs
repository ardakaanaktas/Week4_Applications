using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionPractise
{
    internal interface IEmplooyee
    {
        //Zorunlu olarak girilmesini istediğimiz ortak Propertyler
        public string name { get; set; }//property
        public string surname { get; set; }//property
        public string department { get; set; }//property

        //Methodlar
        public void getJob(string job);

    }
}
