using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaKutuphane
{
    internal class Book
    {
        //Fields
        private string bookName;
        private string author;
        private string authorSurname;
        private int pageNumber;
        private string publisher;
        private DateTime publishYear;

        //Property'ler kullanılarak field'lara erişim sağlandı.
        public string BookName { get => bookName; set => bookName = value; }
        public string Author { get => author; set => author = value; }
        public string AuthorSurname { get => authorSurname; set => authorSurname = value; }
        public int PageNumber { get => pageNumber; set { 
                if (pageNumber > 0)
                {
                    pageNumber = value;    
                } else
                    Console.WriteLine("Geçersiz Sayfa Numarası");
            } 
        }
        public string Publisher { get => publisher; set => publisher = value; }
        public DateTime PublishYear { get => publishYear; set => publishYear = value; }

        //Constructors
        public Book()
        {
            publishYear = DateTime.Now;//Constructor içerisinde publishYear'a şu anki tarih atandı.
        }

        //Constructor with parameters
        public Book(string bookName, string author, int pageNumber, string publisher)
        { 
            this.bookName = bookName;
            this.author = author;
            this.pageNumber = pageNumber;
            this.publisher = publisher;
            publishYear = DateTime.Now;//Constructor içerisinde publishYear'a şu anki tarih atandı.
        }
        //Instance bilgileri yazdırıldı.
        public void ShowBookInfo()
        {
            Console.WriteLine("Book Name: {0}", bookName);
            Console.WriteLine("Author: {0} {1}", author, authorSurname);
            Console.WriteLine("Page Number: {0}", pageNumber);
            Console.WriteLine("Publisher: {0}", publisher);
            Console.WriteLine("Publish Year: {0}", publishYear.ToString("yyyy-MM-dd"));
        }
    }
}
