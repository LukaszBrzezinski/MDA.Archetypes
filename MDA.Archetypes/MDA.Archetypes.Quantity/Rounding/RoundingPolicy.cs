namespace MDA.Archetypes.Quantity.Rounding;

public record RoundingPolicy(int NumberOfDigits, decimal RoundingStep, RoundingStrategy RoundingStrategy, int RoundingDigit = 5);
