
// Le Pont est un patron de conception structurel qui permet 
// de séparer une grosse classe ou un ensemble de classes connexes 
// en deux hiérarchies — abstraction et implémentation
// — qui peuvent évoluer indépendamment l’une de l’autre.

using Bridge;

Console.WriteLine(new Abstraction(new ImplementationA()).Operation());
Console.WriteLine(new Abstraction(new ImplementationB()).Operation());