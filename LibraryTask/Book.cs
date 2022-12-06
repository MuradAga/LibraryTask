using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTask
{
    internal class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public Author Author { get; set; }
        public List<Janr> Janrs { get; set; }
        public Book(int id, string name, int stock, Author author, List<Janr> janrs)
        {
            this.Id = id;
            this.Name = name;
            this.Stock = stock;
            this.Author = author;
            this.Author.Books.Add(this);
            this.Janrs = janrs;
            for (int i = 0; i < janrs.Count; i++)
            {
                this.Janrs[i].Books.Add(this);
            }
        }

        public void ReserveBook()
        {
            if (this.Stock == 0)
            {
                Console.WriteLine("Stokda yoxdur");
            }
            else
            {
                this.Stock--;
                Console.WriteLine("Kitab alindi");
            }
        }
        public void ReturnBook()
        {
            this.Stock++;
            Console.WriteLine("Kitab qaytarildi");
        }
    }
}
