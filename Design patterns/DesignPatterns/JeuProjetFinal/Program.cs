using JeuProjetFinal.Decorator;

IPotion potion = new Potion();
IPotion multiplyPotion = new MultiplyPotion(potion);

Console.WriteLine(potion.Give());
Console.WriteLine(multiplyPotion.Give());
Console.WriteLine(new MultiplyPotion(multiplyPotion).Give());