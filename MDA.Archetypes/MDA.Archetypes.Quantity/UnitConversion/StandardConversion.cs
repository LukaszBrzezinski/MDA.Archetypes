using MDA.Archetypes.Quantity.Units;

namespace MDA.Archetypes.Quantity.UnitConversion;

public record StandardConversion(decimal ConversionFactor, Unit SourceUnit, Unit TargetUnit);
