using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("(DocumentWorker) Document is open");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("(DocumentWorker) You can modify the document if u have the Pro version");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("(DocumentWorker) You can save the document if u have the Pro version");
        }
    }

    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("(ProDocumentWorker) Document`s been modified");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("(ProDocumentWorker) Document`s been saved in old format. Saving in new format is available in Expert version");
        }
    }

    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("(ExpertDocumentWorker) Document`s been saved in new format");
        }
    }
}
