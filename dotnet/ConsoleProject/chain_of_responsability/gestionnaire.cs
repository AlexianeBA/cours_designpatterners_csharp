public class Vehicule : ObjetBase
{
    protected override bool DonneDescription()
    {
        Console.WriteLine("Description du véhicule.");
        return true;
    }
}

public class Modele : ObjetBase
{
    protected override bool DonneDescription()
    {
        Console.WriteLine("Description du modèle.");
        return true;
    }
}

public class Marque : ObjetBase
{
    protected override bool DonneDescription()
    {
        Console.WriteLine("Description de la marque.");
        return true;
    }
}