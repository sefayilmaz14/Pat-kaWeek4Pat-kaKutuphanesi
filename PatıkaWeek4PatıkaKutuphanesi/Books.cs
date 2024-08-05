using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatıkaWeek4PatıkaKutuphanesi
{
    public class Books
    {

        //Field Tanımlamaları
        public string _bookName;
        public string _writerName;
        public string _writerSurname;
        public string _bookPageNumber;
        public string _publisher;
        DateTime _registrationDate = DateTime.Now;

        //Propetry Tanımlamaları

        public string BookName { get; set; }
        public string WriterName { get; set; }
        public string WriterSurname { get; set; }
        public string BookPageNumber { get; set; }
        public string Publisher { get; set; }

        //Default Constructor tanımlaması
        public Books()
        {
            
        }
        //Parametre alan Constructor tanımlaması
        public Books(string bookname, string writername ,string writersurname, string bookpagenumber ,string publisher )
        {
            BookName = bookname;
            WriterName = writername;
            WriterSurname = writersurname;
            BookPageNumber = bookpagenumber;
            Publisher= publisher;
            

        }
        // Constructor tarafından üretilen nesnelerin kullanıcıya gösterilmesini sağlayan method
        public void Display()
        {
            _registrationDate = DateTime.Now;
            
            Console.WriteLine($"{WriterName} {WriterSurname} adlı yazarın {BookPageNumber} sayfalık, {Publisher} yayınevinden çıkan {BookName} kitabını oluşturunuz.");
        }

        // Kullanıcın oluşturulan nesneleri liste halinde görmesini sağlayan method
        public void ListDisplay()
        {
            
            Console.WriteLine($"{BookName}      {WriterName}      {WriterSurname}         {BookPageNumber}           {Publisher}  {_registrationDate}");
        }



    }
}
