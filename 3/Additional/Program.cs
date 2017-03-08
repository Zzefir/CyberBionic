using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional
{
    class Program
    {
        static void Main(string[] args)
        {
            PrinterRed redPrint = new PrinterRed();
            redPrint.Print("Red Hello");

            PrinterGreen greenPrint = new PrinterRed();
            greenPrint.Print("Green Hello");

            Printer whitePrint = new PrinterGreen();
            whitePrint.Print("White Hello");

            Console.ReadKey();
        }
    }
}
