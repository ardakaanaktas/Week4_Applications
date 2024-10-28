using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPractise
{
    internal class Triangle: Shape//Üçgen sınıfı Shape sınıfından türetilmiştir.
    {
        public override double Area()//Üçgen alanı hesaplama metodu, override edilmiştir.
        {
            return 0.5 * height * width;
        }
    }
}
