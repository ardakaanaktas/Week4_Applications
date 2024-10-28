namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathOperations operations = new MathOperations();
            Console.WriteLine(operations.add(1, 2));
            Console.WriteLine(operations.add(1, 2, 3));
            Console.WriteLine(operations.add(4.5, 6.4));
        }
    }
}
