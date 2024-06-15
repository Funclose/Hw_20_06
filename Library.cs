using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_20_06
{
    internal class Library : IEnumerable<Book>
    {
        public string Name { get; set; }
        public string Addres { get; set; }
        public List<Book> Books { get; set; }

        public Library(string name, string addres, List<Book> books)
        {
            Name=name;
            Addres = addres;
            Books = books;

        }

        public IEnumerator<Book> GetEnumerator()
        {
            
           return Books.GetEnumerator(); 

        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return Books.GetEnumerator();
        }
    }
}
