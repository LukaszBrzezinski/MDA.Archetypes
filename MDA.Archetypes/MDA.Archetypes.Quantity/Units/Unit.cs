namespace MDA.Archetypes.Quantity.Units;

public abstract class Unit : Metric
{
    public abstract SystemOfUnits SystemOfUnits { get; }

    public override bool Equals(object? obj)
    {
        return obj is Unit unit &&
               Name == unit.Name &&
               Definition == unit.Definition &&
               Symbol == unit.Symbol &&
               EqualityComparer<SystemOfUnits>.Default.Equals(SystemOfUnits, unit.SystemOfUnits);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Definition, Symbol, SystemOfUnits);
    }
}
