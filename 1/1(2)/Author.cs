using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2_
{
    class Author
    {
        public string author;

        public string NewAuthor { set; get; }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(NewAuthor);
        }
    }
}
