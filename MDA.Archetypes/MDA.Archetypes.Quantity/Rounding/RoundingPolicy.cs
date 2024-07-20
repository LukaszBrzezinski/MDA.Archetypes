namespace MDA.Archetypes.Quantity.Rounding;

public class RoundingPolicy
{
    public int NumberOfDigits { get; }
    public int RoundingDigit { get; }
    public int RoundingStep { get; }
    public RoundingStrategy RoundingStrategy { get; }

    public RoundingPolicy(int numberOfDigits, int roundingStep, RoundingStrategy roundingStrategy, int roundingDigit = 5)
    {
        NumberOfDigits = numberOfDigits;
        RoundingStep = roundingStep;
        RoundingStrategy = roundingStrategy;
        RoundingDigit = roundingDigit;
    }
}