public class RemiseCommand : ICommand
{
    private readonly Vehicule vehicule;
    private readonly double tauxRemise;
    private double prixOriginal;

    public RemiseCommand(Vehicule vehicule, double tauxRemise)
    {
        this.vehicule = vehicule;
        this.tauxRemise = tauxRemise;
    }

    public void Execute()
    {
        prixOriginal = vehicule.Prix;
        vehicule.Prix -= vehicule.Prix * tauxRemise;
        Console.WriteLine($"Remise appliquée : {vehicule.Prix}");
    }

    public void Undo()
    {
        vehicule.Prix = prixOriginal;
        Console.WriteLine($"Remise annulée : {vehicule.Prix}");
    }
}