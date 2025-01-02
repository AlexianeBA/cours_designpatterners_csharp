
    public class Particulier : DocOfficiels
    {
        public Rib CreateRib()
        {
            return new SimplifieRib();
        }

        public Attestation CreateAttestation()
        {
            return new StandardAttestation();
        }
    }
