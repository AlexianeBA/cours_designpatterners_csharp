# cours_designpatterners_csharp

## Introduction
Les design patterns sont des solutions typiques à des problèmes courant dans la concéption de logiciels orienté objet.
Design patterns écrit par 4 dev en 1995 

## Chapitre 1: Introduction aux Design Patterns
- schéma contistué d'objet qui forme une solution a un problème connu et fréquent 
- les obj dans ce schéma sont décris par des censemble de classes et de relations
- les design patterns se retrouve toujours dans le cadre de la POO 
- les patterns sont des modèles réutilisable dans tous les langages
- ils sont basés sur les bonnes pratique
- ils sont représentés pas des diagrammes UML
- pour chaque pattern : Nom, description, exemple sous forme de diagramme (UML), la structure générique du patterns, le cas d'utilisation, un exemple de code, https://refactoring.guru/

## Chapitre 2: 
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

## Chapitre 3:
- patterns de construction : d'abstaire les mécanisme de création d'obj qui permettent d'optimiser 
- une interface permet d'établir des relations entre obj
- interface donne un comportement commun qui va s'appliquer à toutes les classes 
- singleton : construire des classes avec une seule instance
- en c# une instruction de création de classe : 
```csharp
var object = new Myclass(); // création d'une instance de la classe MyClass
```

dans certains cas il est nécessaire de parametrer la construction d'obj:

```csharp
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
```
abstract factory design pattern : le but est de créer des objets regroupés en famille sans devoir connaitre les classes concrètes destinées à la création de ces objets.


lorsqu'on implémente une interface = la classe doit en hériter


Pattern Builder: le but est de séparer la construction d'objets complexe
Contexte : lorsqu'on achète un véhicule on est pris en charge par un commercial. Il y a beaucoup de document à remplir. Ils sont disponibles au format pdf ou html selon le choix du client.


Pattern Singleton: permet d'assurer qu'une classe ne possède qu'une seule instance au cours de l'execution du programme 
Une méthode de classe unique qui retourne cette instance

Prototype pattern:
Création de nouveaux objets par duplication d'objets existants
On les appelle Prototype et ils ont une capacité de clonage.

Le design pattern Prototype permet de créer des copis d'objets existants sans rendre le code dépendant de leur classe concrète. Au lieu de créer un objet à partir de zéro on clône un objet existant (le protorype) et on le modifie si besoin. C'est comme faire une photocopie d'un docuement: on copie l'original et on peut modifier la copie. L'avantage principal est la création d'objets complexes simplifiée.

Cas d'usage: 
- objets avec de nombreuses configuration (éditeur graphique: formes géométriques)
- En jeux vidéo, crétion d'énemis et leur variations en grande quantité
- création d'une configuartion par défaut dans un jeu/logiciel (permet de restaurer le défaut rapidement et de configurer à nouveau)
- Pour éviter la création d'objets systemes couteux: connexions réseaux, ressources partagées.

## Chapitre 9 : Patterns de structuration
permet de faciliter l'indépendance d'un objet vis à vis de son implémentation. Ils encapsulent la composition des objets. Dans le cas d'un ensemble d'objet, il s'agit aussi de rendre cette interface indépendante de la hiérarchie des classes et de la composition des objets.
Les patterns de structuration encapsulent la composition des objets (augmentation du niveau d'abstraction)
Précedemment les patterns de création encapsulaient la création des objets.

Pattern Adapter : Convertir l'interface d'une classe existante en une interface attendue par ses clients (afin qu'ils puissent travailler ensemble)
Autrement dit c'est fournir une nouvelle interface pour répondre aux besoins de clients.


Bridge:
Séparer l'aspect d'implémentation d'un objet de son aspect représentation de l'interface.
Le patern Bridge sépare une grosse classe en deux partie qui peuvent être développer indépendamment.
Exemple avec une télécommande TV:
- Abstraction: La télécommande (les boutons volumes, chaines, ...)
- Implémentation : les marques de TV (Sony, Samsung,...)

```java
//Abstraction
class Telecommande {
    protected TV tv;
    public void MonterLeSon(){
        tv.MonterLeSon();
    }
}

//implémentation
interface TV {
    void MonterLeSon();

}
class TVSony implements TV {
    public void MonterLeSon(){
        System.out.printIn("Sony: Monter le son");
    }
}

class TVSamsung implements TV {
    public void MonterLeSon(){
        System.out.printIn("Samsung: Monter le son");
    }
}
```
Avantages:
- On peut changer la marque de la TV sans changer la télécommande
- On peut modifier la télécommande sans toucher au code des TVs
- On peut ajouter des nouvelles marques de TV
C'est comme si on avait une prise universelle qui fonctionne avec différentes prises éléectriques, l'interface est la même mais l'implémentation est différente selon le pays.


Décorateur :
Le but du pattern est d'ajouter dynamiquement des fonctionnalités supplémentaires à un objet.
Aucune modification de l'interface de l'objet
Transparent vis-a-vis des clients
Une alternative à la création d'une sous-classe pour enrichir un objet. 

## Chapitre 17: Pattern de comportement
L'objectif : fournir des solutions pour distibuer les traitements et le algorithmes entre les objets.

Chain of Responsability : 
Construit une chaine d'objet telle que si un objet de la chaine ne peut pas répondre à la requête il puisse la transmettre à son successeur et ce jusqu'à ce que l'un des objet réponde.
Une chaîne d'objets doit gérer une requête selon un ordre défini dynamiquement.
La façon dont une chaine d'objets gère une requête ne doit pas être connue par ses clients.

Command Pattern:
Command permet de transformer une requête en un objet, ce qui facilite les opérations comme les annulations ou le "retour en arrière", ou encore les mises en file d'attente des demandes et leur suivi.