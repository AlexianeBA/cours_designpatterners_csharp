public class DocumentHtml : Document
{
    public DocumentHtml(string contenu) : base(contenu) { }

    public override void affiche()
    {
        Console.WriteLine("Document HTML : " + contenu);
    }
}
