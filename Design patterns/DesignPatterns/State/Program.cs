// État est un patron de conception comportemental qui permet de modifier le comportement
// d’un objet lorsque son état interne change. L’objet donne l’impression qu’il change de classe.

using State;

Context context= new Context();
context.CurrentState = new NormalState();

Random random = new Random(37);

for (int i = 5; i <= 25 ; i++)
{
    int command = random.Next(3);
    Console.WriteLine(context.Request(command));
}