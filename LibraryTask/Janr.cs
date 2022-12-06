using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTask
{
    internal class Janr
    {
        public int Id { get; set; }
        public string JanrName { get; set; }
        public List<Book> Books { get; set; }
        public Janr(int janrId, string janrName)
        {
            this.Id = janrId;
            this.JanrName = janrName;
            this.Books = new List<Book>();
        }
        public void GetBooksByJanr()
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
}
