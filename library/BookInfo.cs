using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    internal class BookInfo
    {
        private string author;
        private string title;

        public BookInfo(string author, string title)
        {
            this.author = author;
            this.title = title;
        }
        //second constructor with constructor chaining
        public BookInfo(string title): this(null, title) 
        {
            //constructor chaonning:calls the first constroctor with default author "null"
        }
        
        //ToString() mthod overrode
        public override string ToString() 
        {
            return $"{author} - {title}"; 
        }
    }
}
