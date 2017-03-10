using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask
{
    class Footer:AbstractBaseClass 
    {
        string content;

        public override string Content
        {
            get
            {
                if (content != null)
                    return content;
                else
                    return "Нижний колонтитул отсутствует.";
            }
            set
            {
                content = value;
            }
        }

        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
