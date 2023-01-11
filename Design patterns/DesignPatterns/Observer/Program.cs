// L’Observateur est un patron de conception comportemental
// qui permet de mettre en place un mécanisme de souscription
// pour envoyer des notifications à plusieurs objets,
// au sujet d’événements concernant les objets qu’ils observent.


using Observer;

Subject subject = new();
Observer.Observer observer = new("Center", subject, "\t\t");
Observer.Observer observer2 = new("Right", subject, "\t\t\t\t");
subject.Go();