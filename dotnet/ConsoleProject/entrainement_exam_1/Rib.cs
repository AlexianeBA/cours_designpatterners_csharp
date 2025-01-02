
    public abstract class Rib
    {
        public abstract void Print();
    }

    public class SimplifieRib : Rib
    {
        public override void Print()
        {
            Console.WriteLine("Relevé d'Identité Bancaire Simplifié");
        }
    }

    public class DetailRib : Rib
    {
        public override void Print()
        {
            Console.WriteLine("Relevé d'Identité Bancaire Détaillé avec SIRET");
        }
    }
