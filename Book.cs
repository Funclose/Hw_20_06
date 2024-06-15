using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_20_06
{
     internal class Book: IComparable<Book>
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public int Pages { get; set; }

        public Book(string name, string author,int year, int pages) 
        {
            Name = name;
            Author = author;
            Year = year;
            Pages = pages;
        }

        public static int CompareByNameAscending(Book x, Book y)
        {
            return x.Name.CompareTo(y.Name);
        }

        public static int CompareByNameDescending(Book x, Book y)
        {
            return y.Name.CompareTo(x.Name);
        }

        public override string ToString()
        {
            return $"{Name},{Author},{Year},{Pages} pages";
        }

        public int CompareTo(Book el)
        {
            if (el == null) return 1;
            return this.Name.CompareTo(el.Name);
        }
    }
}
