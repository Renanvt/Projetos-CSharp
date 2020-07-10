using System;

namespace HerancaMultiplaEOProblemaDoDiamante.Devices
{
    //class ComboDevice : Scanner, Printer [PROBLEMA DO DIAMANTE]
    class ComboDevice : Device, IScanner, IPrinter // A classe ComboDevice herda de device e implementa também as interfaces IScanner e IPrinter
    {
        public void Print(string doc)
        {
            Console.WriteLine("ComboDevice print " + doc);
        }

        public override void ProcessDoc(string doc)
        {
            Console.WriteLine("ComboDevice processing " + doc);
        }

        public string Scan()
        {
            return "Combodevice scan result";
        }
    }
}
