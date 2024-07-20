namespace MDA.Archetypes.Quantity.Units;

public class Second : SiBaseUnit
{
    public override string Name { get; } = "Second";

    public override string Definition { get; } = "One second is the time that elapses during 9,192,631,770 (or 9.192631770 x 109 in decimal form) cycles of the radiation produced by the transition between two levels of the cesium-133 atom.";

    public override string Symbol { get; } = "s";
}
