public class Vehicule
{
    public string Nom { get; set; }
    public double Prix { get; set; }

    public Vehicule(string nom, double prix)
    {
        Nom = nom;
        Prix = prix;
    }

    public override string ToString()
    {
        return $"{Nom} - Prix: {Prix}";
    }
}