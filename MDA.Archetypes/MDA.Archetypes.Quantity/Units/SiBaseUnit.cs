namespace MDA.Archetypes.Quantity.Units;

public abstract class SiBaseUnit : Unit
{
    public override SystemOfUnits SystemOfUnits { get; } = new SystemOfUnits("SI", "BIPM");
}
