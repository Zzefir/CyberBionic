using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose TXT, XML or DOC: ");
            string type = Console.ReadLine();
            Console.WriteLine("Write the name of document");
            string name = Console.ReadLine();

            if(type == "TXT")
            {
                AbstractHandler document = new TXTHandler(name);
                document.Open();
                document.Create();
                document.Change();
                document.Save();
            }
            else if (type == "DOC")
            {
                AbstractHandler document = new DOCHandler(name);
                document.Open();
                document.Create();
                document.Change();
                document.Save();
            }
            else if(type == "XML")
            {
                AbstractHandler document = new XMLHandler(name);
                document.Open();
                document.Create();
                document.Change();
                document.Save();
            }
            else
            {
                Console.WriteLine("No such type!");
            }

            Console.ReadKey();
        }
    }
}
