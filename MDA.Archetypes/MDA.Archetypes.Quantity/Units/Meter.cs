namespace MDA.Archetypes.Quantity.Units;

public class Meter : SiBaseUnit
{
    public override string Name { get; } = "Meter";

    public override string Definition { get; } = "The meter is the length of the path travelled by light in a vacuum during a time interval of 1/299,792,458 of a second";

    public override string Symbol { get; } = "m";
}
