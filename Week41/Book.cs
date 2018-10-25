using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week41
{
    public class Book
    {
        private string _isbn;
        private string _title;
        private string _author;
        private int _noOfPages;

        public string ISBN { get { return _isbn; } }
        public string Title { get { return _title; } }
        public string Author { get { return _author; } }
        public int NoOFPages { get { return _noOfPages; } }

        public string AllInformation
        {
            get
            {
                return "ISBN: " + _isbn + ", \"" + _title + "\", by " + _author + " (" + _noOfPages + " pages)";
            }
        }

        public Book(string isbn, string title, string author, int noOfPages)
        {
            _isbn = isbn;
            _title = title;
            _author = author;
            _noOfPages = noOfPages;
        }
    }
}

