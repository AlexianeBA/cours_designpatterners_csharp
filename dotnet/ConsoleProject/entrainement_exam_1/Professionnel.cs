
    public class Professionnel : DocOfficiels
    {
        public Rib CreateRib()
        {
            return new DetailRib();
        }

        public Attestation CreateAttestation()
        {
            return new LegalAttestation();
        }
    }
