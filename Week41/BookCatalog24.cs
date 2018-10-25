using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week41
{
    public class BookCatalog24
    {
        private Dictionary<string, Book> _books;

        public BookCatalog24()
        {
            _books = new Dictionary<string, Book>();
        }

        public void AddBook(Book aBook)
        {
            // Add code that can add the given Book object to the list
            if (LookupBook(aBook.ISBN) == null)
            {
                _books.Add(aBook.ISBN, aBook);
            }
            else
            {
                Console.WriteLine("Cannot add already excisting book");
            }
        }

        public void PrintAllBooks()
        {
            // Add code that can print all books in the list
            // Hint: You will need a repetition statement
            foreach(KeyValuePair<string, Book> b in _books)
            {
                Console.WriteLine(b.Value.AllInformation);
            }
        }

        public Book LookupBook(string isbn)
        {
            Book matchingBook = null;
            foreach(KeyValuePair<string, Book> book in _books)
            {
                if(book.Value.ISBN == isbn)
                {
                    matchingBook = book.Value;
                }
            }
            return matchingBook;
        }
    }
}
