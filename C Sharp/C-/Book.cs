using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    class Book
    {
        public string name;
        public string author;
        private int pages;

        public Book(string aName, string aAuthor, int aPages)
        {
            name = aName;
            author = aAuthor;
            Pages = aPages;
        }

        public bool thick()
        {
            if (pages > 200)
            {
                return true;
            }
            return false;
        }

        public int Pages
        {
            get { return pages; }
            set { 
                if ((value % 2) == 0)
                {
                    pages = value;
                }
                else
                {
                    pages = 999;
                }
            }
        }
    }
}
