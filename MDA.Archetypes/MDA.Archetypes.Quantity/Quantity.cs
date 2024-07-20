using MDA.Archetypes.Quantity.Rounding;
using MDA.Archetypes.Quantity.Units;

namespace MDA.Archetypes.Quantity;

public class Quantity : IEquatable<Quantity>
{
    private decimal _value;

    public Metric Metric { get; }

    public decimal GetValue() => _value;

    public Quantity(decimal value, Metric metric)
    {
        _value = value;
        Metric = metric;
    }

    public Quantity Add(Quantity quantity)
    {
        return this;
    }

    public Quantity Substract(Quantity quantity)
    {
        return this;
    }

    public Quantity Multiply(Quantity quantity)
    {
        return this;
    }
    public Quantity Divide(Quantity quantity)
    {
        return this;
    }

    public Quantity Round(RoundingPolicy roundingPolicy)
    {
        return this;
    }

    public bool Equals(Quantity? other)
    {
        if (other == null)
        {
            return false;
        }

        return other.GetValue() == GetValue();
    }

    public override bool Equals(object? obj)
    {
        if (obj is not Quantity quantity)
        {
            return false;
        }

        return Equals(quantity);
    }

    public override int GetHashCode()
    {
        return _value.GetHashCode();
    }
}
