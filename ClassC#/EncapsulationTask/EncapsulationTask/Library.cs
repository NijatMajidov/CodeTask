using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationTask
{
    internal class Library
    {
        Book[] Books = {};

        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length + 1);
            Books[Books.Length - 1] = book;
        }

        public Book[] GetFilteredBooks(string genre)
        {
            Book[] filBooks = {};
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Genre== genre) 
                {
                    Array.Resize(ref filBooks, filBooks.Length + 1);
                    filBooks[filBooks.Length - 1] = Books[i];
                }
               
            }
            return filBooks;
        }

        public Book[] GetFilteredBooks(int minPrice, int maxPrice)
        {
            Book[] filBooks = {}; 
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Price>=minPrice && Books[i].Price<=maxPrice)
                {
                    Array.Resize(ref filBooks, filBooks.Length + 1);
                    filBooks[filBooks.Length - 1] = Books[i];
                    
                }

            }
            return filBooks;
        }

        public void ShowAllBooks()
        {
            Console.WriteLine("N-  | Name       | Price   | Genre   | Count |");
            for(int i = 0;i < Books.Length;i++)
            {
                Books[i].ShowInfo();
            }
        }
    }
}
