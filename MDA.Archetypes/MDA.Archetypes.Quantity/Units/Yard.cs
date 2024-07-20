namespace MDA.Archetypes.Quantity.Units;

public class Yard : ImperialBaseUnit
{
    public override string Name { get; } = "Yard";

    public override string Definition { get; } = "The yard is an English unit of length in both the British imperial and US customary systems of measurement equalling 3 feet or 36 inches. Since 1959 it has been by international agreement standardized as exactly 0.9144 meter. A distance of 1,760 yards is equal to 1 mile.";

    public override string Symbol { get; } = "yd";
}
