# cours_designpatterners_csharp


Design patterns écrit par 4 dev en 1995 

Chap 1:
- schéma contistué d'objet qui forme une solution a un problème connu et fréquent 
- les obj dans ce schéma sont décris par des censemble de classes et de relations
- les design patterns se retrouve toujours dans le cadre de la POO 
- les patterns sont des modèles réutilisable dans tous les langages
- ils sont basés sur les bonnes pratique
- ils sont représentés pas des diagrammes UML
- pour chaque pattern : Nom, description, exemple sous forme de diagramme (UML), la structure générique du patterns, le cas d'utilisation, un exemple de code, https://refactoring.guru/

Chap 2:
- étude de cas : afficher un catalogue de véhicuke destiné à la vente
Cahier des charges :
- véhicules destinés à la vente
- recherche
- catalogue
- option
- panier / gestion de commandes
- paiement 
- gestion client
- 

Chap 3:
- patterns de construction : d'abstaire les mécanisme de création d'obj qui permettent d'optimiser 
- une interface permet d'établir des relations entre obj
- interface donne un comportement commun qui va s'appliquer à toutes les classes 
- singleton : construire des classes avec une seule instance
- en c# une instruction de création de classe : 
var object = new Myclass(); // création d'une instance de la classe MyClass

dans certains cas il est nécessaire de parametrer la construction d'obj:


public class Document
{
    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }
    public DateTime Created { get; set; }
}

public class Program {
    public Document CreateDoc(string typeDoc)
    {
        Document doc = null;

        if (typeDoc == "Word")
        {
            doc = new Document();
            doc.Title = "New Document";
            doc.Content = "Content";
        }
        else if (typeDoc == "Excel")
        {
            doc = new Document();
            doc.Title = "New Excel Document";
            doc.Content = "Excel Content";
        }
        else
        {
            doc = new Document();
            doc.Title = "New Document";
            doc.Content = "Content";
        }
    }
}

abstract factory design pattern : le but est de créer des objets regroupés en famille sans devoir connaitre les classes concrètes destinées à la création de ces objets.


signature de methode : décrit ce qu'elle prend en entrée et ce qu'elle va afficher en sortie.

rond en UML = interface

contexte : 


commande : 
dotnet build = permet de compiler le projet / regénère les exécutable
donet run = lance le projet
lorsqu'on implémente une interface = la classe doit en hériter
