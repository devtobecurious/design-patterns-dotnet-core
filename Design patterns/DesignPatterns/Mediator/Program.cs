// Médiateur est un patron de conception comportemental qui diminue les dépendances chaotiques entre les objets.
// Il restreint les communications directes entre les objets et les force à collaborer uniquement
// via un objet médiateur.

using Mediator;

Mediator.Mediator mediator = new();

Colleague colleague = new(mediator, "Valerie");
Colleague colleague2 = new Colleague2(mediator, "John");

colleague.Send("Meeting, ok ?");
mediator.Block(colleague.Receive);
mediator.UnBlock(colleague.Receive);
