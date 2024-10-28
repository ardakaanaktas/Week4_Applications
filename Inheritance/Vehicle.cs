using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal abstract class Vehicle
    {
        public virtual void drive()//drive metodu Vehicle sınıfında virtual olarak tanımlanmıştır. Bu metot Car sınıfında override edilmiştir.
        {
            Console.WriteLine("Vehicle is driving");
        }

        
    }

    internal sealed class Car : Vehicle//Car sınıfı Vehicle sınıfından türetilmiştir. Bu sınıf sealed olduğu için başka bir sınıf tarafından türetilmesi engellenmiştir.
    {
        public override void drive()
        {
            Console.WriteLine("Car is driving");
        }
    }

    internal class Bus : Vehicle//Bus sınıfı Vehicle sınıfından türetilmiştir.
    {
        public sealed override void drive()
        {
            Console.WriteLine("Bus is driving");
        }
    }

    internal class  PublicBus :Bus 
    {
        /*
         public override void drive(){  sealed olarak işaretlenmiş bir metot override edilemez.
        
        } 
         */
    }
}
