public abstract class Document
{
    protected string contenu;

    public Document(string contenu)
    {
        this.contenu = contenu;
    }

    public abstract void affiche();
}

public class DocumentHtml : Document
{
    public DocumentHtml(string contenu) : base(contenu) { }

    public override void affiche()
    {
        Console.WriteLine("Document HTML : " + contenu);
    }
}

public class DocumentPdf : Document
{
    public DocumentPdf(string contenu) : base(contenu) { }

    public override void affiche()
    {
        Console.WriteLine("Document PDF : " + contenu);
    }
}