using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powtórka_do_Egzaminu
{
    public class Komputer
    {
        public double CPU { get; set; }
        public double RAM { get; set; }
        public static bool operator ==(Komputer k1, Komputer k2)
        {
            return (k1.CPU == k2.CPU & k1.RAM == k2.RAM);

        }
        public static bool operator !=(Komputer k1, Komputer k2)
        {
            return !(k1== k2);

        }
    }
}
