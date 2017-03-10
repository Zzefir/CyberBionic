using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the key: ");
            string key = Console.ReadLine();

            if (key == "pro")
            {
                DocumentWorker worker = new ProDocumentWorker();
                worker.OpenDocument();
                worker.EditDocument();
                worker.SaveDocument();
            }
            else if (key == "exp")
            {
                ProDocumentWorker worker = new ExpertDocumentWorker();
                worker.OpenDocument();
                worker.EditDocument();
                worker.SaveDocument();
            }
            else if (key == "")
            {
                DocumentWorker worker = new DocumentWorker();
                worker.OpenDocument();
                worker.EditDocument();
                worker.SaveDocument();
            }
            else
            {
                Console.WriteLine("NO SUCH KEY!");
            }

            Console.ReadKey();
        }
    }
}
