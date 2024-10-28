namespace PolymorphismPractise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape triangle = new Triangle();//Shape classından türetilen Triangle sınıfı, Shape sınıfının Area metodunu override ettiği için Triangle sınıfının Area metodunu çağırır.
            Shape rectangle = new Rectangle();//Shape classından türetilen Rectangle sınıfı, Shape sınıfının Area metodunu override ettiği için Rectangle sınıfının Area metodunu çağırır.
            Shape square = new Square();//Shape classından türetilen Square sınıfı, Shape sınıfının Area metodunu override ettiği için Square sınıfının Area metodunu çağırır.

            triangle.height = 10;
            triangle.width = 20;
            Console.WriteLine("Üçgen Alanı: " +triangle.Area());//Triangle sınıfının Area metodunu çağırır.

            rectangle.height = 10;
            rectangle.width = 20;
            Console.WriteLine("Dikdörtgen Alanı: " + rectangle.Area());//Rectangle sınıfının Area metodunu çağırır.

            square.height = 10;
            square.width = 10;
            Console.WriteLine("Kare Alanı: " + square.Area());//Square sınıfının Area metodunu çağırır.
        }
    }
}
