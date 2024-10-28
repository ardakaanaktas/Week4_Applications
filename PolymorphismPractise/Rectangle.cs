using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPractise
{
    internal class Rectangle : Shape//Dikdörtgen sınıfı Shape sınıfından türetilmiştir.
    {
        public override double Area()//Dikdörtgen alanı hesaplama metodu, override edilmiştir.
        {
            return height * width;
        }
    }
}
