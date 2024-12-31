public abstract class FormulaireImmatriculation
{
    protected FormulaireImplementation Impl;

    public FormulaireImmatriculation(FormulaireImplementation impl)
    {
        Impl = impl;
    }

    public abstract void Afficher();
    public abstract bool GérerSaisie();
}
