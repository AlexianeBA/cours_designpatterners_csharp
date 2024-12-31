public class FormmulaireHtml: FormulaireImplementation
{
    public void DessineTexte(string texte)
    {
        Console.WriteLine($"HTML: {texte}");
    }

    public string GereZoneTexte()
    {
        Console.Write("HTML Zone de saisie:");
        return Console.ReadLine();
    }
}