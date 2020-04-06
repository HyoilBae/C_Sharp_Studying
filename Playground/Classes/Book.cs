using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Classes
{
    public class Book : IBook, IComparable<Book>
    {
        public string Title { get; set; }
        public int NumberOfPages { get; set; }

        public delegate int CurrentPage();

        private delegate Book ReturnBookDelegate();

        private ReturnBookDelegate ReturnBookMethod;

        public CurrentPage InstanceCurrentPage;

        private Book ReturnBook(string title)
        {
            return new Book(title);
        }

        public Book()
        {

        }

        public Book(string title)
        {
            Title = title;
        }

        public Book(string title, int pages) : this (title)
        {
            NumberOfPages = pages;
        }

        public int CompareTo(Book other)
        {
            return this.Title.CompareTo(other.Title);
        }

        void IBook.CurrentPage()
        {
            throw new NotImplementedException();
        }
    }
}
