using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPractise
{
    internal class Shape
    {
        public double height { get; set; }// Yükseklik Proprty'si
        public double width { get; set; } // Genişlik Proprty'si

        public virtual double Area() //Alan hesaplama metodu, Direkt Shape çağrılırsa 0 döndürür.
        {
            return 0;
        }   
    }
}
