// See https://aka.ms/new-console-template for more information

using Powtórka_do_Egzaminu;
using System.Numerics;


// sprawdzenie operatora ==
Komputer x1 = new Komputer();
Komputer x2 = new Komputer();
x1.CPU = 2;
x2.CPU = 3;

if (x1 == x2) Console.WriteLine("Są takie same");
if(x1 != x2) Console.WriteLine("Chuja a nie podobne");


MetodaMniejWirtualna2 xD = new();

xD.XD();



//action i func
 void PrintMessage(string message)
{
    Console.WriteLine(message);
}
 void PerformAction(Action<string> action)
{
    action("Hello, world!");
}
PerformAction(PrintMessage);


//func różnica jest taka ze jako ostatni parametr podajemy to co ma zwrócić 
 int AddNumbers(int a, int b)
{
    return a + b;
}
 void PerformFunc(Func<int, int, int> func)
{
    int result = func(2, 3);
    Console.WriteLine(result);
}
PerformFunc(AddNumbers);


//order by 

Komputer x3 = new Komputer();
x3.RAM = 1;
x3.CPU = 10;
Komputer x4 = new Komputer();
x4.RAM = 9;
x4.CPU = 8;
List<Komputer> komputery = new List<Komputer>();
komputery.Add(x1);
komputery.Add(x2);
komputery.Add(x3);
komputery.Add(x4);
Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////");

komputery = komputery.OrderByDescending(x => x.CPU).ThenBy(x => x.RAM).ToList();

foreach (Komputer x in komputery)
{
    int i = 0;
    Console.WriteLine($"Komputer {i} ma {x.RAM} ramu i {x.CPU} CPU");
    i++;
}
List<int> num = new List<int>() { 1, 2, 3, 4 };