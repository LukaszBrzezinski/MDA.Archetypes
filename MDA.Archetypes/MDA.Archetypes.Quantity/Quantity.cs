using MDA.Archetypes.Quantity.Rounding;
using MDA.Archetypes.Quantity.Units;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MDA.Archetypes.Quantity;

public class Quantity : IEquatable<Quantity>
{
    private readonly decimal _value;

    public Metric Metric { get; }

    public decimal GetValue() => _value;

    public Quantity(decimal value, Metric metric)
    {
        _value = value;
        Metric = metric;
    }

    public Quantity Add(Quantity quantity)
    {
        return Calculate(quantity, (a, b) => a + b);
    }

    public Quantity Substract(Quantity quantity)
    {
        return Calculate(quantity, (a, b) => a - b);
    }

    public Quantity Multiply(Quantity quantity)
    {
        return Calculate(quantity, (a, b) => a * b);
    }
    public Quantity Divide(Quantity quantity)
    {
        return Calculate(quantity, (a, b) => a / b);
    }

    public Quantity Round(RoundingPolicy roundingPolicy)
    {
        var result = roundingPolicy.RoundingStrategy switch
        {
            RoundingStrategy.Round => Round(_value, roundingPolicy),
            RoundingStrategy.Up => Math.Round(_value, roundingPolicy.NumberOfDigits, MidpointRounding.AwayFromZero),
            RoundingStrategy.Down => Math.Round(_value, roundingPolicy.NumberOfDigits, MidpointRounding.ToZero),
            RoundingStrategy.UpByStep => _value > 0
                                ? Math.Ceiling(_value / roundingPolicy.RoundingStep) * roundingPolicy.RoundingStep
                                : Math.Floor(_value / roundingPolicy.RoundingStep) * roundingPolicy.RoundingStep,
            RoundingStrategy.DownByStep => _value < 0
                                ? Math.Ceiling(_value / roundingPolicy.RoundingStep) * roundingPolicy.RoundingStep
                                : Math.Floor(_value / roundingPolicy.RoundingStep) * roundingPolicy.RoundingStep,
            RoundingStrategy.TowardsPositive => _value >= 0 
                                ? Math.Round(_value, roundingPolicy.NumberOfDigits, MidpointRounding.AwayFromZero) 
                                : Math.Round(_value, roundingPolicy.NumberOfDigits, MidpointRounding.ToZero),
            RoundingStrategy.TowardsNegative => _value >= 0 
                                ? Math.Round(_value, roundingPolicy.NumberOfDigits, MidpointRounding.ToZero) 
                                : Math.Round(_value, roundingPolicy.NumberOfDigits, MidpointRounding.AwayFromZero),
            _ => throw new ArgumentException("Invalid rounding strategy"),
        };

        return new Quantity(result, Metric);
    }

    private static decimal Round(decimal value, RoundingPolicy policy)
    {
        var roundingNumber = (int)(Math.Abs(value) * (decimal)Math.Pow(10, policy.NumberOfDigits + 1) % 10);
        if (roundingNumber >= policy.RoundingDigit) 
        {
            return Math.Round(value, policy.NumberOfDigits, MidpointRounding.AwayFromZero);
        }

        return Math.Round(value, policy.NumberOfDigits, MidpointRounding.ToZero);
    }

    public override bool Equals(object? obj)
    {
        if (obj is Quantity quantity)
        {
            return Equals(quantity);
        }

        return false;    
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(_value, Metric);
    }

    public bool Equals(Quantity? quantity)
    {
        if(quantity is null)
        {
            return false;
        }

        return _value == quantity._value &&
               EqualityComparer<Metric>.Default.Equals(Metric, quantity.Metric);
    }

    private Quantity Calculate(Quantity quantity, Func<decimal, decimal, decimal> equation)
    {
        Validate(quantity);
        var result = equation(_value, quantity.GetValue());

        return new Quantity(result, Metric);
    }

    private void Validate(Quantity quantity)
    {
        ArgumentNullException.ThrowIfNull(quantity);

        if (quantity.Metric != Metric)
        {
            throw new ArgumentException("Metrics does not match.");
        }
    }
}
