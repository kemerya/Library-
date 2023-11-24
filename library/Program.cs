using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create book objects using different constructors
            BookInfo book1 = new BookInfo("j.k rowling","Harry potter");
            BookInfo book2 = new BookInfo( "mokingbird");
            BookInfo book3 = new BookInfo("George orwell","1984");
            
            //print book onformation using TOString()
            console.WriteLine(book1.ToString());
            console.WriteLine(book2.ToString());
            console.Write(book3.ToString());
        }
    }
}
