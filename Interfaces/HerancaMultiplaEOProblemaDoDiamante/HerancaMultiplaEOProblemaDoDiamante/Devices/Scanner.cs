using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaMultiplaEOProblemaDoDiamante.Devices
{
    class Scanner : Device, IScanner //A Interface Scanner herda de Device e implementa a interface IScanner
    {

        public override void ProcessDoc(string doc)
        {
            Console.WriteLine("Scanner processing: "+doc);
        }
        public string Scan()
        {
            return "Scanner scan result";
        }
    }
}
