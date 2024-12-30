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