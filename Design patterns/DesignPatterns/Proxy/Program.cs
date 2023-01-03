// *************************************************************************************************************
//
// La Procuration est un patron de conception structurel qui vous permet d’utiliser un substitut pour un objet.
// Elle donne le contrôle sur l’objet original, vous permettant d’effectuer des manipulations avant ou après
// que la demande ne lui parvienne.
//
// *************************************************************************************************************

using Proxy;

ISubject subject = new Proxy.Proxy();
Console.WriteLine(subject.Request());

ProtectionProxy proxy = new ProtectionProxy();
proxy.Authenticate("Abracadabra");
Console.WriteLine(proxy.Request());