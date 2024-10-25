namespace PatikaKutuphane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();//Instance oluşturuldu.

            book.Author = "Ayşe";//Instance üzerinden değerler atandı.
            book.AuthorSurname = "Kulin";//Instance üzerinden değerler atandı.
            book.PageNumber =398;//Instance üzerinden değerler atandı.
            book.Publisher = "Remzi Kitabevi";//Instance üzerinden değerler atandı.
            book.BookName = "Aylin";//Instance üzerinden değerler atandı.

            book.ShowBookInfo();//Instance üzerinden bilgiler yazdırıldı.

            Console.WriteLine("----------------------------------------------");
            //Aynı kitabı Constructor üzerinden daha instance oluşturulurken tanımlayabiliriz.

            Book book2 = new Book("Aylin", "Ayşe", 398, "Remzi Kitabevi");//Constructor üzerinden instance oluşturuldu.
            book2.ShowBookInfo();//Constructor üzerinden oluşturulan instance'ın bilgileri yazdırıldı.
        }
    }
}
