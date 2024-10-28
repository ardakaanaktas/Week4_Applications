using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Square:Shape
    {
        public double Side { get; set; }

        public override double perimeter()
        {
            return Side * 4;
        }

        public override double Area()
        {
            return Side * Side;
        }
    }
}
