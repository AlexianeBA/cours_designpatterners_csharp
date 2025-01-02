class Program
{
    static void Main(string[] args)
    {
        // Création des prototypes
        var prototypeHabitation = new AssuranceHabitation
        {
            ClausesStandard = new List<string> { "Clause 1", "Clause 2", "Clause 3" }
        };

        var prototypeAutomobile = new AssuranceAutomobile
        {
            ClausesStandard = new List<string> { "Clause A", "Clause B", "Clause C" }
        };

        var prototypeVie = new AssuranceVie
        {
            ClausesStandard = new List<string> { "Clause X", "Clause Y", "Clause Z" }
        };

        // Clonage des prototypes pour créer des contrats personnalisés
        var contratClient1 = prototypeHabitation.Clone() as AssuranceHabitation;
        contratClient1.NomClient = "Client 1";
        contratClient1.DateDebut = DateTime.Now;
        contratClient1.DateFin = DateTime.Now.AddYears(1);
        contratClient1.Montant = 1000;
        contratClient1.AnnexesSpecifiques.Add("Annexe 1");

        var contratClient2 = prototypeAutomobile.Clone() as AssuranceAutomobile;
        contratClient2.NomClient = "Client 2";
        contratClient2.DateDebut = DateTime.Now;
        contratClient2.DateFin = DateTime.Now.AddYears(1);
        contratClient2.Montant = 1500;
        contratClient2.AnnexesSpecifiques.Add("Annexe A");

        // Affichage des détails des contrats
        contratClient1.AfficherDetails();
        Console.WriteLine();
        contratClient2.AfficherDetails();
    }
}