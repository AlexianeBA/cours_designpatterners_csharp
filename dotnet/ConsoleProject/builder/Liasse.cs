public abstract class Liasse
{
    protected IList<Document> documents = new List<Document>();

    public void ajouteDocument(Document document)
    {
        documents.Add(document);
    }

    public void affiche()
    {
        foreach (Document document in documents)
        {
            document.affiche();
        }
    }
}

public class LiasseHtml : Liasse { }

public class LiassePdf : Liasse { }