
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Documents pour un client Particulier :");
            DocOfficiels particulierFactory = new Particulier();
            Rib particulierRIB = particulierFactory.CreateRib();
            Attestation particulierAttestation = particulierFactory.CreateAttestation();

            particulierRIB.Print();
            particulierAttestation.Print();

            Console.WriteLine("\nDocuments pour un client Professionnel :");
            DocOfficiels professionnelFactory = new Professionnel();
            Rib professionnelRIB = professionnelFactory.CreateRib();
            Attestation professionnelAttestation = professionnelFactory.CreateAttestation();

            professionnelRIB.Print();
            professionnelAttestation.Print();
        }
    }
