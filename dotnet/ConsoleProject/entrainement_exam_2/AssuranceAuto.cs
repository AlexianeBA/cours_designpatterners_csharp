public class AssuranceAutomobile : ContratAssurance
{
    public override ICloneable Clone()
    {
        return this.MemberwiseClone() as ICloneable;
    }
}