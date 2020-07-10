using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaMultiplaEOProblemaDoDiamante.Devices
{
    abstract class Device
    {
        public int SerialNumber { get; set; }
        public abstract void ProcessDoc(string doc);
    }
}
