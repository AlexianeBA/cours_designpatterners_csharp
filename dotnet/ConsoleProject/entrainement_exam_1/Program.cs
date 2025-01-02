class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Documents pour un client Particulier :");
            IAbstractFactory particulierFactory = new ParticulierFactory();
            RIB particulierRIB = particulierFactory.CreateRIB();
            Attestation particulierAttestation = particulierFactory.CreateAttestation();

            particulierRIB.Print();
            particulierAttestation.Print();

            Console.WriteLine("\nDocuments pour un client Professionnel :");
            IAbstractFactory professionnelFactory = new ProfessionnelFactory();
            RIB professionnelRIB = professionnelFactory.CreateRIB();
            Attestation professionnelAttestation = professionnelFactory.CreateAttestation();

            professionnelRIB.Print();
            professionnelAttestation.Print();
        }
    }