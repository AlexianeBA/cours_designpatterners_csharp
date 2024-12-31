public class FormulaireImmatriculationLuxembourg: FormulaireImmatriculation
{
    public FormulaireImmatriculationLuxembourg(FormulaireImplementation impl): base(impl)
    {
    }

    public override void Afficher()
    {
        Impl.DessineTexte("Formulaire d'immatriculation - Luxembourg");
        Impl.DessineTexte("Numéro de plaque existante (format Luxembourg) : ");
    }

    public override bool GérerSaisie()
    {
        string plaque = Impl.GereZoneTexte();
        return plaque.Length == 7;
    }
}