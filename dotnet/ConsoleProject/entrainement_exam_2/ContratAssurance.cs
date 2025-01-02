public abstract class ContratAssurance : ICloneable
{
    public string NomClient { get; set; }
    public DateTime DateDebut { get; set; }
    public DateTime DateFin { get; set; }
    public double Montant { get; set; }
    public List<string> ClausesStandard { get; set; } = new List<string>();
    public List<string> AnnexesSpecifiques { get; set; } = new List<string>();

    public abstract ICloneable Clone();

    public void AfficherDetails()
    {
        Console.WriteLine($"Client: {NomClient}");
        Console.WriteLine($"Date de début: {DateDebut}");
        Console.WriteLine($"Date de fin: {DateFin}");
        Console.WriteLine($"Montant: {Montant}");
        Console.WriteLine("Clauses standard:");
        foreach (var clause in ClausesStandard)
        {
            Console.WriteLine($"- {clause}");
        }
        Console.WriteLine("Annexes spécifiques:");
        foreach (var annexe in AnnexesSpecifiques)
        {
            Console.WriteLine($"- {annexe}");
        }
    }
}