// *************************************************************************************************************
//
// Décorateur est un patron de conception structurel qui permet d’affecter dynamiquement
// de nouveaux comportements à des objets en les plaçant dans des emballeurs qui implémentent ces comportements.
//
// *************************************************************************************************************


using Decorator;

IComponent component = new Component();
Client.Display("Basic", component);
Client.Display("Decorator A", new DecoratorA(component));
Client.Display("Decorator B", new DecoratorB(component));
