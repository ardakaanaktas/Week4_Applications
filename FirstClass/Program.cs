namespace FirstClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person ogretmen1 = new Person();

            ogretmen1.Name = "Babuşka";
            ogretmen1.Surname = "Babuşkova";
            ogretmen1.BirthDate = new DateTime(1938, 10, 10);

            Console.WriteLine(ogretmen1.Name);
            Console.WriteLine(ogretmen1.Surname);
            Console.WriteLine(ogretmen1.BirthDate.ToString());

            Person ogrenci1 = new Person();

            ogrenci1.Name = "Vladimir";
            ogrenci1.Surname = "Putin";
            ogrenci1.BirthDate = new DateTime(1952, 10, 7);

            Console.WriteLine(ogrenci1.Name);
            Console.WriteLine(ogrenci1.Surname);
            Console.WriteLine(ogrenci1.BirthDate.ToString());

            Person ogrenci2 = new Person();

            ogrenci2.Name = "Donald";
            ogrenci2.Surname = "Trump";
            ogrenci2.BirthDate = new DateTime(1946, 6, 14);

            Console.WriteLine(ogrenci2.Name);
            Console.WriteLine(ogrenci2.Surname);
            Console.WriteLine(ogrenci2.BirthDate.ToString());

            Person ogrenci3 = new Person();

            ogrenci3.Name = "Joe";
            ogrenci3.Surname = "Biden";
            ogrenci3.BirthDate = new DateTime(1942, 11, 20);

            Console.WriteLine(ogrenci3.Name);
            Console.WriteLine(ogrenci3.Surname);
            Console.WriteLine(ogrenci3.BirthDate.ToString());
        }
    }
}
