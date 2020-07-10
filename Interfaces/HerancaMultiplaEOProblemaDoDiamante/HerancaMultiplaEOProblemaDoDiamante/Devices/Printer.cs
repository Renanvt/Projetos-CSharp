using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaMultiplaEOProblemaDoDiamante.Devices
{
    class Printer : Device, IPrinter
    {
        public string Scan { get; set; }
        public override void ProcessDoc(string doc) //Implementacao de Device
        {
            Console.WriteLine("Printer processing: "+ doc);
        }
        public void Print(string doc) //Implementacao da interface Iprinter
        {
            Console.WriteLine("Printer print " + doc);
        }
    }
}
