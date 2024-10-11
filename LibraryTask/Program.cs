namespace LibraryTask;

internal class Program
{
    static void Main(string[] args)
    {
        Author Araz = new(1, "Araz", "Merdanov");
        Author Murad = new(2, "Murad", "Agazade");

        Janr bedii = new(1, "Bedii");
        Janr elmi = new(2, "Elmi");
        Janr romantik = new(3, "Romantik");
        Janr publisistik = new(4, "Publisistik");

        Book book_1 = new(1, "Kitab adi 1", 2, Araz, new List<Janr>() { bedii, elmi });

        Book book_2 = new(2, "Kitab adi 2", 5, Murad, new List<Janr>() { romantik });
        Book book_3 = new(3, "Kitab adi 3", 6, Murad, new List<Janr>() { elmi });

        //romantik.GetBooksByJanr();  //janri romantik olan kitablari getirir

        //Araz.GetBooksByAuthor();   // yazicisi Araz olan kitablari getirir

        //book_1.ReserveBook();
        //book_1.ReserveBook();
        //book_1.ReturnBook();
        //book_1.ReserveBook();
    }
}