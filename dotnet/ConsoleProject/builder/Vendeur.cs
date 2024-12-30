public class Vendeur
{
    private ConstructeurLiasseVehicule constructeur;

    public Vendeur(ConstructeurLiasseVehicule constructeur)
    {
        this.constructeur = constructeur;
    }

    public Liasse construit(string nomClient)
    {
        constructeur.construitBonDeCommande(nomClient);
        constructeur.construitDemandeImmatriculation(nomClient);
        return constructeur.resultat();
    }
}