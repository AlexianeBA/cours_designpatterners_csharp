// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Builder");

ConstructeurLiasseVehicule constructeur;
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
Console.WriteLine("Veuillez entrer le nom du client :");
        string nomClient = Console.ReadLine();

Vendeur vendeur = new Vendeur(constructeur);
Liasse liasse = vendeur.construit(nomClient);
liasse.affiche();
