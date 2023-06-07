using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powtórka_do_Egzaminu
{
    public class Pojazdy
    {
        public int ID { get; set; }
        public virtual ICollection<Tankowania> Tankowanias { get; set; }
    }
    public class Tankowania
    {
        public int IdTankowania { get; set; }
        public virtual ICollection<Pojazdy> Pojazdys { get; set;}
    }
}
