public interface ConstructeurLiasseVehicule
{
    void construitBonDeCommande(string nomClient);
    void construitDemandeImmatriculation(string nomDemandeur);
    Liasse resultat();
}

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

public class ConstructeurLiasseVehiculePdf : ConstructeurLiasseVehicule
{
    private Liasse liasse = new LiassePdf();

    public void construitBonDeCommande(string nomClient)
    {
        string contenu = "PDF Bon de commande Client : " + nomClient;
        liasse.ajouteDocument(new DocumentPdf(contenu));
    }

    public void construitDemandeImmatriculation(string nomDemandeur)
    {
        string contenu = "PDF Demande d'immatriculation Demandeur : " + nomDemandeur;
        liasse.ajouteDocument(new DocumentPdf(contenu));
    }

    public Liasse resultat()
    {
        return liasse;
    }
}