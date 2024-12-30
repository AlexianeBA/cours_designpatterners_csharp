public class ConstructeurLiasseVehiculeHtml : ConstructeurLiasseVehicule
{
    private Liasse liasse = new LiasseHtml();

    public void construitBonDeCommande(string nomClient)
    {
        string contenu = "<HTML>Bon de commande Client : " + nomClient + "</HTML>";
        liasse.ajouteDocument(new DocumentHtml(contenu));
    }

    public void construitDemandeImmatriculation(string nomDemandeur)
    {
        string contenu = "<HTML>Demande d'immatriculation Demandeur : " + nomDemandeur + "</HTML>";
        liasse.ajouteDocument(new DocumentHtml(contenu));
    }

    public Liasse resultat()
    {
        return liasse;
    }
}
