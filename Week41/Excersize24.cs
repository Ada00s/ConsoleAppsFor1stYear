﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week41
{
    class Excersize24
    {
        public static void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            Book b1 = new Book("AD1337", "Java for All", "John Potter", 352);
            Book b2 = new Book("XS3220", "Gardening", "Alex Sohn", 220);
            Book b3 = new Book("DD0095", "Cars in the USA", "Susan Dreyer", 528);
            Book b4 = new Book("PT1295", "Copenhagen Dawn", "Dan Mygind", 104);

            BookCatalog24 theCatalog = new BookCatalog24();
            theCatalog.AddBook(b1);
            theCatalog.AddBook(b2);
            theCatalog.AddBook(b3);
            theCatalog.AddBook(b4);
            theCatalog.AddBook(new Book("AD1337", "title", "author", 241));

            Console.WriteLine("------------- Printing all books ---------------");
            theCatalog.PrintAllBooks();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine(theCatalog.LookupBook("AD1337") == null ? "Book not found..." : theCatalog.LookupBook("AD1337").AllInformation);
            Console.WriteLine(theCatalog.LookupBook("AD1338") == null ? "Book not found..." : theCatalog.LookupBook("AD1338").AllInformation);
            Console.WriteLine(theCatalog.LookupBook("PT1295") == null ? "Book not found..." : theCatalog.LookupBook("PT1295").AllInformation);
            Console.WriteLine(theCatalog.LookupBook("......") == null ? "Book not found..." : theCatalog.LookupBook("......").AllInformation);
            Console.WriteLine(theCatalog.LookupBook("ad1337") == null ? "Book not found..." : theCatalog.LookupBook("ad1337").AllInformation);

            // The LAST line of code should be ABOVE this line
        }
    }
}
