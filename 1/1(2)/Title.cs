using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2_
{
    class Title
    {
        public string title;
        public string NewTitle { set; get; }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(NewTitle);
        }
    }
}
