public abstract class ObjetBase
{
    protected ObjetBase nextHandler;

    public void SetNextHandler(ObjetBase nextHandler)
    {
        this.nextHandler = nextHandler;
    }

    public void GetDescription()
    {
        if (!DonneDescription())
        {
            if (nextHandler != null)
            {
                nextHandler.GetDescription();
            }
            else
            {
                DescriptionParDefaut();
            }
        }
    }

    protected abstract bool DonneDescription();

    protected void DescriptionParDefaut()
    {
        Console.WriteLine("Description par défaut de l'objet.");
    }
}