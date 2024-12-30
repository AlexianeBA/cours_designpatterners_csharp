// See https://aka.ms/new-console-template for more information
using System;
Console.WriteLine("Builder");



 
        ConstructeurLiasseVehicule constructeur = null;
        Console.WriteLine("Voulez-vous des documents HTML (1) ou PDF (2) ?");
        string choix = Console.ReadLine();

        if (choix == "1")
        {
            constructeur = new ConstructeurLiasseVehiculeHtml();
        }
        else
        {
            constructeur = new ConstructeurLiasseVehiculePdf();
        }

        Vendeur vendeur = new Vendeur(constructeur);
        Liasse liasse = vendeur.construit("Martin");
        liasse.affiche();
    