class Program
{
    static void Main(string[] args)
    {
        FormulaireImplementation htmlImpl = new FormmulaireHtml();
        FormulaireImmatriculation formulaireFrance = new FormulaireImmatriculationFrance(htmlImpl);
        formulaireFrance.Afficher();
        formulaireFrance.GérerSaisie();
    

    Console.WriteLine();

    FormulaireImplementation appletImpl = new FormulaireApplet();
    FormulaireImmatriculation formulaireLuxembourg = new FormulaireImmatriculationLuxembourg(appletImpl);
    formulaireLuxembourg.Afficher();
    formulaireLuxembourg.GérerSaisie();
    }
}
