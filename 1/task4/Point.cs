using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Point
    {
        private int field1, field2;
        private string field3;
        
        public int Field1
        {
            get { return field1; }
        }
        
        public int Field2
        {
            get { return field2; }
        } 

        public string Field3
        {
            get { return field3; }
        }

        public Point()
        {

        }

        public Point (int field1, int field2, string field3)
        {
            this.field1 = field1;
            this.field2 = field2;
            this.field3 = field3;
        }
    }
}
