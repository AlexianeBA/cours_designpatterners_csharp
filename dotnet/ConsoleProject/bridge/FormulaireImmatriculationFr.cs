public class FormulaireImmatriculationFrance: FormulaireImmatriculation
{
    public FormulaireImmatriculationFrance(FormulaireImplementation impl): base(impl)
    {
    }

    public override void Afficher()
    {
        Impl.DessineTexte("Nouvelle immatriculation française: ");
        Impl.DessineTexte("Numéro de plaque existante: ");
    }

    public override bool GérerSaisie()
    {
        string plaque = Impl.GereZoneTexte();
        if (plaque.Length != 7)
        {
            Impl.DessineTexte("La plaque doit contenir 7 caractères");
            return false;
        }
        else
        {
            Impl.DessineTexte($"Plaque {plaque} enregistrée pour la France.");
            return true;
        }
    }
}