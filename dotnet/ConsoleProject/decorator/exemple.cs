public interface ICafe 
{
    double GetCost();
    string GetDescription();
}

public class CafeSimple : ICafe
{
    public double GetCost() => 2.0;
    public string GetDescription() => "Café simple";
}

public abstract class CafeDecorator : ICafe
{
    protected ICafe cafe;

    public CafeDecorator(ICafe cafe)
    {
        this.cafe = cafe;
    }

    public virtual double GetCost() => cafe.GetCost();
    public virtual string GetDescription() => cafe.GetDescription();
}

public class Lait : CafeDecorator
{
    public Lait(ICafe cafe) : base(cafe) { }

    public override double GetCost() => base.GetCost() + 0.5;
    public override string GetDescription() => base.GetDescription() + " + lait";
}

public class Sucre : CafeDecorator
{
    public Sucre(ICafe cafe) : base(cafe) { }

    public override double GetCost() => base.GetCost() + 0.2;
    public override string GetDescription() => base.GetDescription() + " + sucre";
}

// Utilisation
ICafe monCafe = new CafeSimple();
monCafe = new Lait(monCafe);
monCafe = new Sucre(monCafe);


//Explication:

// Le code utilise le pattern Decorator pour ajouter dynamiquement des fonctionnalités supplémentaires (lait et sucre) à un objet (ICafe) sans modifier son interface. 
// Les classes Lait et Sucre héritent de CafeDecorator et ajoutent leurs propres coût et description au café de base.


//Explication correction:

//Les participants

//Interface Composant (ICafe) :

//C'est l'interface de base qui définit les opérations communes.
//Elle déclare deux méthodes : GetCost() et GetDescription().
//Tous les cafés (simples ou décorés) doivent implémenter cette interface.
//Composant Concret (CafeSimple) :

//C'est l'objet de base qui peut être décoré.
//Implémente l'interface ICafe.
//Représente un café simple sans ajouts.
//Définit le coût de base (2.0€) et la description de base ("Café simple").
//Décorateur Abstrait (CafeDecorator) :

//Classe abstraite qui implémente l'interface ICafe.
//Maintient une référence vers un objet ICafe (le café à décorer).
//Délègue toutes les opérations à l'objet décoré.
//Sert de base pour tous les décorateurs concrets.
//Décorateurs Concrets (Lait et Sucre) :

//Héritent du décorateur abstrait.
//Ajoutent des comportements supplémentaires :
//Lait : ajoute 0.5€ au coût et "+ lait" à la description.
//Sucre : ajoute 0.2€ au coût et "+ sucre" à la description.