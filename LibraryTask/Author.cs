namespace LibraryTask;

internal class Author
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<Book> Books { get; set; }
    public Author(int id, string firstName, string lastName)
    {
        this.Id = id;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Books = new List<Book>();
    }
    public Author()
    {

    }
    public void GetBooksByAuthor()
    {
        foreach (var book in this.Books)
        {
            Console.Write($@"Kitab Id: {book.Id}
Kitab Ad: {book.Name}
Kitab Stok Sayi: {book.Stock}
Kitab Yazici: {book.Author.FirstName} {book.Author.LastName}
Kitab Janrlari: ");

            foreach (var janr in book.Janrs)
            {
                Console.Write(janr.JanrName + ", ");
            }
        }
    }
}
