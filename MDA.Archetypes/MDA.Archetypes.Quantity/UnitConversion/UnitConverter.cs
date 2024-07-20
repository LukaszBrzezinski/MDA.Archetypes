using MDA.Archetypes.Quantity.Units;

namespace MDA.Archetypes.Quantity.UnitConversion;

public class UnitConverter
{
    private readonly List<StandardConversion> _standardConversions;

    public UnitConverter(IEnumerable<StandardConversion> standardConversions)
    {
        _standardConversions = standardConversions.ToList();
    }

    public Quantity Convert(Quantity quantity, Unit targetUnit)
    {
        ArgumentNullException.ThrowIfNull(quantity);
        ArgumentNullException.ThrowIfNull(targetUnit);

        if (quantity.Metric == targetUnit)
        {
            return quantity;
        }

        var conversion = _standardConversions
            .SingleOrDefault(sc => sc.SourceUnit == quantity.Metric && sc.TargetUnit == targetUnit)
            ?? throw new ConversionException($"Could not convert {quantity.Metric.Name} to {targetUnit.Name}. Standard conversion missing.");

        var value = conversion.ConversionFactor * quantity.GetValue();

        return new Quantity(value, targetUnit);
    }
}
