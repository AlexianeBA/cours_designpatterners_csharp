public class Program
{
    public static void Main(string[] args)
    {
        Vehicule vehicule1 = new Vehicule("Voiture A", 10000);
        Vehicule vehicule2 = new Vehicule("Voiture B", 15000);

        CommandManager commandManager = new CommandManager();

        ICommand remiseVehicule1 = new RemiseCommand(vehicule1, 0.1); // 10% de remise
        ICommand remiseVehicule2 = new RemiseCommand(vehicule2, 0.2); // 20% de remise

        commandManager.ExecuteCommand(remiseVehicule1);
        commandManager.ExecuteCommand(remiseVehicule2);

        Console.WriteLine(vehicule1); // Voiture A - Prix: 9000
        Console.WriteLine(vehicule2); // Voiture B - Prix: 12000

        commandManager.UndoLastCommand();
        Console.WriteLine(vehicule2); // Voiture B - Prix: 15000

        commandManager.UndoLastCommand();
        Console.WriteLine(vehicule1); // Voiture A - Prix: 10000
    }
}