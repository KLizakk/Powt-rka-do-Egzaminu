using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Powtórka_do_Egzaminu
{
    public class MetodaWirtualna
    {
        public virtual void XD()
        {
            Console.WriteLine("XDXD");
        }
    }

    public class MetodaMniejWirtualna : MetodaWirtualna
    {
        public  override void XD()
        {
            Console.WriteLine("Nadpisalem");
        }
    }
    public class MetodaMniejWirtualna2 : MetodaWirtualna
    {
        public override void XD()
        {
            Console.WriteLine("Nadpisalem xD");
        }
    }
}
