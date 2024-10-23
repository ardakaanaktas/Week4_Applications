using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Robot
    {
        public string name;
        public int model;
        public int batteryLevel;

        public void greeting()
        {
            Console.WriteLine("Hello, I am a robot. My name is " + name + " and my model is " + model);
        }

        public void chargeBattery()
        {
            batteryLevel = 100;
            Console.WriteLine("Battery level is now at " + batteryLevel + "%");
        }

        public void move(int distance)
        {
            if (batteryLevel > 0 && batteryLevel > distance)
            {
                Console.WriteLine("Moving " + distance + " meters");
                batteryLevel -= distance;
                Console.WriteLine("Battery level is now at " + batteryLevel + "%");
            }
            else
            {
                Console.WriteLine("Battery level is too low to move");
            }
        }

    }
}
