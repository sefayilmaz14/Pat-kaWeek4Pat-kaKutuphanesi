

using PatıkaWeek4PatıkaKutuphanesi;

class Program
{
    static void Main(string[] args)
    {
        //Default Constructor veri girişi
        Books book1 = new Books();
        book1.WriterName = "Ahmet";
        book1.WriterSurname = "Yılma";
        book1.BookPageNumber = "320";
        book1.BookName = "Kitap A";
        book1.Publisher = "Alfa Yayınları";
        book1.Display();

        //Parametre alan Constructor
        Books book2 = new Books("Kitap B" , "Ayşe" , "Karan", "215" , "Beta Yayıncılık");
        book2.Display();

        //Default Constructor veri girişi
        Books book3 = new Books();
        book3.WriterName = "Mehmet";
        book3.WriterSurname = "Demir";
        book3.BookPageNumber = "450";
        book3.BookName = "Kitap C";
        book3.Publisher = "Gamma Yayınları";
        book3.Display();

        //Parametre alan Constructor
        Books book4 = new Books("Kitap D", "Elif", "Şahin", "275", "Delta Yayıncılık");
        book4.Display();

        //Parametre alan Constructor
        Books book5 = new Books("Kitap E", "Selin", "Yurt", "198", "Epsilon Yayınları");
        book5.Display();

        //Kullanıcının girişi yapılan verinin liste halinde gösterilip gösterilmemesinin sorulması
        Console.WriteLine("\n\nKitap Listesini Görmek İStermisiniz evet / hayır");
        string input = "";
        input = Console.ReadLine().ToLower();
        if (input == "evet")
        {
            Console.WriteLine("Kitap Adı  Yazar Adı  Yazar Soyadı  Sayfa Sayısı      Yayın Evi     Kayıt Tarihi");
            book1.ListDisplay();
            book2.ListDisplay();
            book3.ListDisplay();
            book4.ListDisplay();
            book5.ListDisplay();
        }
        else
        {
            return;
        }
    }


    // Class: İlgil verinin özellik, yöntem method vb bilgilerinin girildiği ve daha sonra bu bilgilerin farklı class ve main içerisinde daha kolay kullanılmasını sağlayan şablonlardır.
    // Propetry: Alanlarda belirtilen özelliklerin işlenmesi için kullanılan kısımdır.
    // New : Bir Class da oluşturulan verinin farklı bir class yada maine çağrılması için kullanılır.
    // Constructor :Bir class ta oluşan nesnenin başlangıç durumu ve istenilen işlemlerin yapılmasını sağlayan özel bir yöntemdir. 

}
