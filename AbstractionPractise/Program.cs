namespace AbstractionPractise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emplooyee emplooyee = new Emplooyee();//Emplooyee class'ından bir nesne oluşturduk.

            Console.Write("Adınızı Giriniz: ");
            emplooyee.name = Console.ReadLine();//Kullanıcıdan ad bilgisini aldık.
            Console.Write("Soyadınızı Giriniz: ");
            emplooyee.surname = Console.ReadLine();//Kullanıcıdan soyad bilgisini aldık.
            Console.Write("Departmanınızı Giriniz: ");
            emplooyee.department = Console.ReadLine();//Kullanıcıdan departman bilgisini aldık.
            Console.Write("İş tanımınızı giriniz:");
            emplooyee.job = Console.ReadLine();//Kullanıcıdan iş bilgisini aldık.

            emplooyee.getInfo();//Emplooyee class'ındaki getInfo methodunu çağırdık.
            emplooyee.getJob(emplooyee.job);//oluşturduğumuz nesne üzerinden getJob methodunu çağırdık.
        }
    }
}
