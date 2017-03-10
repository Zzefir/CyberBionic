using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class DOCHandler:AbstractHandler
    {
        public DOCHandler(string name)
            : base(name)
        {

        }

        public override void Open()
        {
            Console.WriteLine("DOCHandler Open({0})", name);
        }
        public override void Create()
        {
            Console.WriteLine("DOCHandler Create({0})", name);
        }
        public override void Change()
        {
            Console.WriteLine("DocHandler Change({0})", name);
        }
        public override void Save()
        {
            Console.WriteLine("DocHandler Save({0})", name);
        }
    }
}
