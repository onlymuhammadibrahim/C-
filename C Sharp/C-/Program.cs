using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Potter", "jk rol", 401);
            Book book2 = new Book("Sindbad", "IBM", 150);

            

            Console.WriteLine(book1.Pages);

            usefulTools.sayHi("IBM");
            
            Console.ReadLine();
        }
    }
}