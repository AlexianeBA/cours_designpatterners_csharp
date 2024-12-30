public class DocumentPdf : Document
{
    public DocumentPdf(string contenu) : base(contenu) { }

    public override void affiche()
    {
        Console.WriteLine("Document PDF : " + contenu);
    }
}