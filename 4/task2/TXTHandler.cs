using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class TXTHandler:AbstractHandler
    {
        public TXTHandler(string name)
            : base(name)
        {

        }
        public override void Open()
        {
            Console.WriteLine("TXTHandler Open({0})", name);
        }
        public override void Create()
        {
            Console.WriteLine("TXTHandler Create({0})", name);
        }
        public override void Change()
        {
            Console.WriteLine("TXTHandler Change({0})", name);
        }
        public override void Save()
        {
            Console.WriteLine("TXTHandler Save({0})", name);
        }
    }
}
