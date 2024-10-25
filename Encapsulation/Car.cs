using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Car
    {
        //Fields
        private string brand;
        private string model;
        private int doorCount;
        private string color;

        //Properties
        public string Brand { get => brand; set => brand = value; }
        public string Model { get => model; set => model = value; }
        public int DoorCount { get => doorCount; set {
                if (value == 2 || value == 4)//Araba kapı sayısı 2 veya 4 olabilir.
                {
                    doorCount = value;
                }
                else//Değilse hata mesajı ver ve kapı sayısını -1 yap.
                {
                    Console.WriteLine("Kapı sayısı 2 veya 4'ten farklı olamaz.");
                    doorCount = -1;
                }
            } 
        }
        public string Color { get => color; set => color = value; }

        //Methods
        public void showCarInfo()
        {
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Door Count: " + DoorCount);
            Console.WriteLine("Color: " + Color);
        }
    }
}
