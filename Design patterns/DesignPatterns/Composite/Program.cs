// Composite est un patron de conception structurel qui permet d’agencer
// les objets dans des arborescences afin de pouvoir traiter celles-ci
// comme des objets individuels.
using Composite;
using Microsoft.VisualBasic;

IComponent<string> album = new Composite<string>("Album");

IComponent<string> point = album;
point.Add(new Component<string>("Photo"));
point.Add(new Component<string>("Photo"));

IComponent<string> newYear = new Composite<string>("2022");
album.Add(newYear);

newYear.Add(new Component<string>("Display"));
