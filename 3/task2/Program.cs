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
            Pupil p1 = new BadPupil();
            Pupil p2 = new ExcelentPupil();

            ClassRoom group = new ClassRoom(p1, p2); 

            group.Study();
            group.Read();
            group.Write();
            group.Relax();

            Console.ReadKey();
        }
    }
}
