// L’Adaptateur est un patron de conception structurel qui permet de faire collaborer
// des objets ayant des interfaces normalement incompatibles.


using Adapter;

Adaptee first = new Adaptee();
Console.WriteLine(first.SpecificRequest(5, 3));

ITarget second = new Adapter.Adapter();
Console.WriteLine(second.Request(5));