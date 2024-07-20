namespace MDA.Archetypes.Quantity.Units;

public abstract class ImperialBaseUnit : Unit
{
    public override SystemOfUnits SystemOfUnits { get; } = new SystemOfUnits("Imperial", "British Parliament");

    public static ImperialBaseUnit Yard { get; } = new Yard();
    // other units
}
