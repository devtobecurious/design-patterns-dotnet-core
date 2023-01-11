// Chaîne de responsabilité est un patron de conception comportemental qui permet de faire circuler des demandes
// dans une chaîne de handlers. Lorsqu’un handler reçoit une demande, il décide de la traiter ou de l’envoyer
// au handler suivant de la chaîne.

using ResponsabilityChain;

Handler start = null;

for (int i = 5; i > 0; i--)
{
    start = new Handler(i, start);
}

int[] data = { 50, 2000, 1500, 10000, 175, 4500 };
foreach (var item in data)
{
    Console.WriteLine(start.HandleRequest(item));
}