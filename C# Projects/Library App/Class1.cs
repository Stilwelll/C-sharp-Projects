using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_App
{
    class Book
    {
        public string title;
        public string category;
        public int pageCount;
        
        public Book(string atitle, string acategory, int apageCount)
        {
            title = atitle;
            category = acategory;
            pageCount = apageCount;
        }

        public void DisplayBook()
        {
            Console.WriteLine(title);
            Console.WriteLine(category);
            Console.WriteLine(pageCount);
        }
    }
}
