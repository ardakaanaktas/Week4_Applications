using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethods
{
    internal class Baby
    {
        private string name;
        private string surname;
        private DateTime birthDate;
        private static int babyCount = 0;


        public static int BabyCount //property
        {
            get { return babyCount; } //getter
            set { babyCount = value; } //setter
        }



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

        public Baby()
        {
            babyBorn();//Bebek doğduğu anda ağlıyor
            babyCount++;//Her yeni bebek oluşturulduğunda babyCount artar
            this.birthDate = DateTime.Now;//Bebeğin doğum anı constructor çağrıldığı an
        }

        public Baby(string name, string surname)
        {
            babyBorn(); //Bebek doğduğu anda ağlıyor
            babyCount++;//Her yeni bebek oluşturulduğunda babyCount artar
            this.name = name;
            this.surname = surname;
            this.birthDate = DateTime.Now;//Bebeğin doğum anı constructor çağrıldığı an
        }

        private void babyBorn()
        {
            Console.WriteLine("Ingaaaaa");//Bebek doğduğunda ağlar
        }
    }
}
