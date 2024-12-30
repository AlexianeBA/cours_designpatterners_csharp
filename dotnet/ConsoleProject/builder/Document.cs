public abstract class Document
{
    protected string contenu;

    public Document(string contenu)
    {
        this.contenu = contenu;
    }

    public abstract void affiche();
}


