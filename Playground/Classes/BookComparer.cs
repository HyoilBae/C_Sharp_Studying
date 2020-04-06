using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Classes
{
    public class BookComparer : IComparer<Book>
    {
            public enum CompareField
            {
                Title,
                NumberOfPages
            }

            public CompareField SortBy = CompareField.Title;

            public int Compare(Book a, Book b)
            {
                switch (SortBy)
                {
                    case CompareField.Title:
                        return a.Title.CompareTo(b.Title);
                    case CompareField.NumberOfPages:
                        return a.NumberOfPages.CompareTo(b.NumberOfPages);
                }
                return a.Title.CompareTo(b.Title);
            }
        }
}
