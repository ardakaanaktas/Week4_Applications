namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Baby baby = new Baby();

            baby.Name = "Ali";
            baby.Surname = "Veli";
            

            Console.WriteLine("Baby Name: " + baby.Name);
            Console.WriteLine("Baby Surname: " + baby.Surname);
            Console.WriteLine("Baby BirthDate: " + baby.BirthDate);

            Baby baby2 = new Baby("Bele","Vaziyet");

            Console.WriteLine("Baby Name: " + baby2.Name);
            Console.WriteLine("Baby Surname: " + baby2.Surname);
            Console.WriteLine("Baby BirthDate: " + baby2.BirthDate);
        }
    }
}
