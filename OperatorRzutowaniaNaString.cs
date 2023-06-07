using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powtórka_do_Egzaminu
{
    public class Komputerr
    {
        public double CPU { get; set; }
        public double RAM { get; set; }
        public static explicit operator string(Komputerr komputer)
        {
            return $"CPU: {komputer.CPU}, RAM: {komputer.RAM}";
        }
    }
    //Komputerr komputer = new Komputerr() { CPU = 3.2, RAM = 16 };
    //string info = (string)komputer;
    //Console.WriteLine(info); // wyświetli "CPU: 3.2, RAM: 16"


}
