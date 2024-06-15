using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_20_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            {
               books.Add(new Book("asdfff", "Jack",1955, 335));
               books.Add(new Book("asdff", "Jacka",1655, 135));
               books.Add(new Book("asdf", "Jackb",1355, 235));
            };
            Console.WriteLine("------------------------------");


            books.Sort((x, y) => x.Name.CompareTo(y.Name));
            Console.WriteLine("sotred by alphavit: ");
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }

            Console.WriteLine("------------------------------");
            books.Sort((x, y) => y.Name.CompareTo(x.Name));
            Console.WriteLine("sotred after reverse: ");
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }
        
    }
}
