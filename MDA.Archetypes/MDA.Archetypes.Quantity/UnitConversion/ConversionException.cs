﻿namespace MDA.Archetypes.Quantity.UnitConversion;

public class ConversionException : Exception
{
    public ConversionException(string? message) : base(message)
    {
    }
}
