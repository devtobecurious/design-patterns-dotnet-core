using JeuProjetFinal;
using JeuProjetFinal.Bridge;
using JeuProjetFinal.Decorator;
using JeuProjetFinal.Proxy;

// Décorateur
IPotion potion = new Potion();
IPotion multiplyPotion = new MultiplyPotion(potion);

Console.WriteLine(potion.Give());
Console.WriteLine(multiplyPotion.Give());
Console.WriteLine(new MultiplyPotion(multiplyPotion).Give());

// Proxy
IPlaneteProxy proxy = new CachePlaneteProxy();
var list = proxy.GetList();

// Bridge
ICharacter character = new Enemy(new Baguette());
