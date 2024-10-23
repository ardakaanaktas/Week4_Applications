using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class CofeeMachine
    {
        private string model;
        private string brand;
        private int waterLevel;
        private int cofeeBeans;

        public string Model
        {
            get { return model;}
            set { model = value; brand = value; }
        }

        public int WaterLevel
        {
            get { return waterLevel; }
            set
            {
                if (value >= 0)
                {
                    waterLevel = value;
                }
            }
        }

        public int CofeeBeans
        {
            get { return cofeeBeans; }
            set
            {
                if (value >= 0)
                {
                    cofeeBeans = value;
                }
            }
        }

        public void makeCofee()
        {
            if (waterLevel >= 200 && cofeeBeans >= 15)
            {
                Console.WriteLine("Cofee is ready!");
                waterLevel -= 200;
                cofeeBeans -= 15;
            }
            else
            {
                Console.WriteLine("Not enough water or cofee beans!");
            }

        }


        public void addWater(int water)
        {
            if (water <= 1000)
            {
                waterLevel += water;

                Console.WriteLine($"{water} ml su eklendi. Haznede ki su miktarı : {waterLevel}");
            }
        }

        public void addCofeeBeans(int beans)
        {
            if (beans <= 100)
            {
                cofeeBeans += beans;

                Console.WriteLine($"{beans} gr kahve eklendi. Haznede ki kahve miktarı : {cofeeBeans}");
            }
        }
    }
}