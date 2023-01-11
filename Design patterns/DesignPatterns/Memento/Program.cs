// Mémento est un patron de conception comportemental qui permet de sauvegarder
// et de rétablir l’état précédent d’un objet sans révéler les détails de son implémentation.

using Memento;

Caretaker[] careters = new Caretaker[10];
Originator originator = new Originator();
int move = 0;
Simulator strings= new Simulator();

foreach (var item in strings)
{
    if (item[0] == '*' && move > 0)
    {
        originator.Restore(careters[move- 1].Memento);
    }
    else
    {
        originator.Operation(item);
    }
    careters[move] = new Caretaker();
    careters[move].Memento = originator.Save();
}