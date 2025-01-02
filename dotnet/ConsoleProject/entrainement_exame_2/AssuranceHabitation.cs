public class AssuranceHabitation : ContratAssurance
{
    public override ICloneable Clone()
    {
        return this.MemberwiseClone() as ICloneable;
    }
}