public class AssuranceVie : ContratAssurance
{
    public override ICloneable Clone()
    {
        return this.MemberwiseClone() as ICloneable;
    }
}
