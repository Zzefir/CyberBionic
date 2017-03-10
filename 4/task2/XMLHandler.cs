using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class XMLHandler:AbstractHandler
    {
        public XMLHandler(string name)
            : base(name)
        {

        }
        public override void Open()
        {
            Console.WriteLine("XMLHandler Open({0})", name);
        }
        public override void Create()
        {
            Console.WriteLine("XMLHandler Create({0})", name);
        }
        public override void Change()
        {
            Console.WriteLine("XMLHandler Change({0})", name);
        }
        public override void Save()
        {
            Console.WriteLine("XMLHandler Save({0})", name);
        }
    }
}
