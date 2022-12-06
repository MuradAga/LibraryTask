namespace LibraryTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Author Araz = new Author(1, "Araz", "Merdanov");
            Author Murad = new Author(2, "Murad", "Agazade");

            Janr bedii = new Janr(1, "Bedii");
            Janr elmi = new Janr(2, "Elmi");
            Janr romantik = new Janr(3, "Romantik");
            Janr publisistik = new Janr(4, "Publisistik");

            Book book_1 = new Book(1, "Kitab adi 1", 2, Araz, new List<Janr>() { bedii, elmi});

            Book book_2 = new Book(2, "Kitab adi 2", 5, Murad, new List<Janr>() { romantik });
            Book book_3 = new Book(3, "Kitab adi 3", 6, Murad, new List<Janr>() { elmi });

            //romantik.GetBooksByJanr();  //janri romantik olan kitablari getirir

            //Araz.GetBooksByAuthor();   // yazicisi Araz olan kitablari getirir

            //book_1.ReserveBook();
            //book_1.ReserveBook();
            //book_1.ReturnBook();
            //book_1.ReserveBook();
        }
    }
}