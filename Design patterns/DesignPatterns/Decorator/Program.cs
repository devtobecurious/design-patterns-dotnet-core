using Decorator;

IComponent component = new Component();
Client.Display("Basic", component);
Client.Display("Decorator A", new DecoratorA(component));
Client.Display("Decorator B", new DecoratorB(component));
