using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPractise
{
    internal class Square: Shape//Kare sınıfı Shape sınıfından türetilmiştir.
    {
        public override double Area()//Kare alanı hesaplama metodu, override edilmiştir.
        {
            if (height == width)//Eğer yükseklik ve genişlik eşitse kare olur.
            {
                return height * width;//Kare alanı hesaplaması
            }
            else//Eğer yükseklik ve genişlik eşit değilse
            {
                Console.WriteLine("Genişlik ve Yükseklik Kare için eşit olmalıdır.");
                return 0;
            }
        }
    }
}
