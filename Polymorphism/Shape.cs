using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Shape
    {
        public virtual double Area()
        {
            return 0;
        }

        public virtual double perimeter()
        {
            return 0;
        }
    }
}
