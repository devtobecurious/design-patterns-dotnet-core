// Monteur est un patron de conception de création
// qui permet de construire des objets complexes étape par étape.
// Il permet de produire différentes variations ou représentations d’un objet en utilisant
// le même code de construction.

using Builder;

Director director = new();

IBuilder b1 = new Builder1();
IBuilder b2 = new Builder2();

Product p1 = director.Construct(b1);
Product p2 = director.Construct(b2);