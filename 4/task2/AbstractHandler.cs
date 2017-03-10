using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    abstract class AbstractHandler
    {
        protected string name;

        public AbstractHandler(string name)
        {
            this.name = name;
        }

        abstract public void Open();
        abstract public void Create();
        abstract public void Change();
        abstract public void Save();
    }
}
