using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Powtórka_do_Egzaminu;

public class Generyczne
{
//    Typy generyczne to mechanizm w językach programowania, który umożliwia tworzenie funkcji i klas, które
//mogą działać z różnymi typami danych.Dzięki temu kod może być bardziej elastyczny i łatwiejszy do
//utrzymania, ponieważ nie trzeba tworzyć osobnych funkcji lub klas dla każdego typu danych.
    public static T Max<T>(T a, T b) where T : IComparable<T>
    {
        return a.CompareTo(b) > 0 ? a : b;
    }
    public class Lista<T>
    {
        private List<T> _elementy = new List<T>();
        public void Dodaj(T element)
        {
            _elementy.Add(element);
        }
        public T Pobierz(int indeks)
        {
            return _elementy[indeks];
        }
    }

}

