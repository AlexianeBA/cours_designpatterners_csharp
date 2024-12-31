public class FormulaireApplet: FormulaireImplementation
{
    public void DessineTexte(string texte)
    {
        Console.WriteLine($"Applet: {texte}");
    }

    public string GereZoneTexte()
    {
        Console.Write("Applet Zone de saisie:");
        return Console.ReadLine();
    }
}