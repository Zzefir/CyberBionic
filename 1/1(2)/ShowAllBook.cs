using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2_
{
    class ShowAllBook
    {
        static void Main(string[] args)
        {
            string author = Console.ReadLine();
            string content = Console.ReadLine();
            string title = Console.ReadLine();

            Book book = new Book(author, title, content);

            book.Show();

            Console.ReadKey();

        }
    }
}
