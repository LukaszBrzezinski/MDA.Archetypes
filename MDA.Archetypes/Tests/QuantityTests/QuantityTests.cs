using FluentAssertions;
using MDA.Archetypes.Quantity;
using MDA.Archetypes.Quantity.Rounding;
using MDA.Archetypes.Quantity.Units;

namespace QuantityTests;

public class QuantityTests
{
    [Fact]
    public void Equals_WhenSameMetricAndValue_RetunTrue()
    {
        var quantity1 = new Quantity(1, SiBaseUnit.Meter);
        var quantity2 = new Quantity(1, SiBaseUnit.Meter);

        var result = quantity1.Equals(quantity2);

        result.Should().BeTrue();
    }

    [Fact]
    public void Equals_WhenSameMetricAndDifferentValue_ReturnFalse()
    {
        var quantity1 = new Quantity(1, SiBaseUnit.Meter);
        var quantity2 = new Quantity(999, SiBaseUnit.Meter);

        var result = quantity1.Equals(quantity2);

        result.Should().BeFalse();
    }

    [Fact]
    public void Equals_WhenDifferentMetricAndSameValue_ReturnFalse()
    {
        var quantity1 = new Quantity(1, SiBaseUnit.Meter);
        var quantity2 = new Quantity(1, ImperialBaseUnit.Yard);

        var result = quantity1.Equals(quantity2);

        result.Should().BeFalse();
    }

    [Fact]
    public void Equals_WhenNull_ReturnFalse()
    {
        var quantity1 = new Quantity(1, SiBaseUnit.Meter);

        var result = quantity1.Equals(null);

        result.Should().BeFalse();
    }

    [Fact]
    public void Add_ReturnsValidResult()
    {
        var quantity1 = new Quantity(1, SiBaseUnit.Meter);
        var quantity2 = new Quantity(100, SiBaseUnit.Meter);

        var result = quantity1.Add(quantity2);

        result.Should().Be(new Quantity(101, SiBaseUnit.Meter));
    }

    [Fact]
    public void Add_WhenMetricNotMatching_ThrowsException()
    {
        var quantity1 = new Quantity(1, SiBaseUnit.Meter);
        var quantity2 = new Quantity(100, ImperialBaseUnit.Yard);

        var act = () => quantity1.Add(quantity2);

        act.Should().Throw<ArgumentException>();
    }

    [Fact]
    public void Add_WhenNull_ThrowsException()
    {
        var quantity1 = new Quantity(1, SiBaseUnit.Meter);

        var act = () => quantity1.Add(null!);

        act.Should().Throw<ArgumentNullException>();
    }

    [Fact]
    public void Substract_ReturnsValidResult()
    {
        var quantity1 = new Quantity(1, SiBaseUnit.Meter);
        var quantity2 = new Quantity(100, SiBaseUnit.Meter);

        var result = quantity1.Substract(quantity2);

        result.Should().Be(new Quantity(-99, SiBaseUnit.Meter));
    }

    [Fact]
    public void Substract_WhenMetricNotMatching_ThrowsException()
    {
        var quantity1 = new Quantity(1, SiBaseUnit.Meter);
        var quantity2 = new Quantity(100, ImperialBaseUnit.Yard);

        var act = () => quantity1.Substract(quantity2);

        act.Should().Throw<ArgumentException>();
    }

    [Fact]
    public void Substract_WhenNull_ThrowsException()
    {
        var quantity1 = new Quantity(1, SiBaseUnit.Meter);

        var act = () => quantity1.Substract(null!);

        act.Should().Throw<ArgumentNullException>();
    }

    [Fact]
    public void Multiply_ReturnsValidResult()
    {
        var quantity1 = new Quantity(12, SiBaseUnit.Meter);
        var quantity2 = new Quantity(100, SiBaseUnit.Meter);

        var result = quantity1.Multiply(quantity2);

        result.Should().Be(new Quantity(1200, SiBaseUnit.Meter));
    }

    [Fact]
    public void Multiply_WhenMetricNotMatching_ThrowsException()
    {
        var quantity1 = new Quantity(1, SiBaseUnit.Meter);
        var quantity2 = new Quantity(100, ImperialBaseUnit.Yard);

        var act = () => quantity1.Multiply(quantity2);

        act.Should().Throw<ArgumentException>();
    }

    [Fact]
    public void Multiply_WhenNull_ThrowsException()
    {
        var quantity1 = new Quantity(1, SiBaseUnit.Meter);

        var act = () => quantity1.Multiply(null!);

        act.Should().Throw<ArgumentNullException>();
    }

    [Fact]
    public void Divide_ReturnsValidResult()
    {
        var quantity1 = new Quantity(120, SiBaseUnit.Meter);
        var quantity2 = new Quantity(12, SiBaseUnit.Meter);

        var result = quantity1.Divide(quantity2);

        result.Should().Be(new Quantity(10, SiBaseUnit.Meter));
    }

    [Fact]
    public void Divide_WhenDivsorIsZero_ThrowsException()
    {
        var quantity1 = new Quantity(10, SiBaseUnit.Meter);
        var quantity2 = new Quantity(0, SiBaseUnit.Meter);

        var act = () => quantity1.Divide(quantity2);

        act.Should().Throw<DivideByZeroException>();
    }

    [Fact]
    public void Divide_WhenDividerIsZero_Returns0()
    {
        var quantity1 = new Quantity(0, SiBaseUnit.Meter);
        var quantity2 = new Quantity(10, SiBaseUnit.Meter);

        var result = quantity1.Divide(quantity2);

        result.Should().Be(new Quantity(0, SiBaseUnit.Meter));
    }

    [Fact]
    public void Divide_WhenMetricNotMatching_ThrowsException()
    {
        var quantity1 = new Quantity(1, SiBaseUnit.Meter);
        var quantity2 = new Quantity(100, ImperialBaseUnit.Yard);

        var act = () => quantity1.Divide(quantity2);

        act.Should().Throw<ArgumentException>();
    }

    [Fact]
    public void Divide_WhenNull_ThrowsException()
    {
        var quantity1 = new Quantity(1, SiBaseUnit.Meter);

        var act = () => quantity1.Divide(null!);

        act.Should().Throw<ArgumentNullException>();
    }

    [Theory]
    [MemberData(nameof(RoundTestCases))]
    public void Round_ReturnsValidResult(decimal value, RoundingPolicy roundingPolicy, decimal expectedResult)
    {
        var quantity = new Quantity(value, SiBaseUnit.Meter);

        var result = quantity.Round(roundingPolicy);

        result.Should().Be(new Quantity(expectedResult, SiBaseUnit.Meter));
    }

    public static TheoryData<decimal, RoundingPolicy, decimal> RoundTestCases = new()
    {
        { 4.45m, new RoundingPolicy(1, 0.1m, RoundingStrategy.Up), 4.5m },
        { -4.45m, new RoundingPolicy(1, 0.1m, RoundingStrategy.Up), -4.5m },

        { 4.45m, new RoundingPolicy(1, 0.1m, RoundingStrategy.Down), 4.4m },
        { -4.45m, new RoundingPolicy(1, 0.1m, RoundingStrategy.Down), -4.4m },

        { 4.45m, new RoundingPolicy(1, 0.1m, RoundingStrategy.Round, 5), 4.5m },
        { -4.45m, new RoundingPolicy(1, 0.1m, RoundingStrategy.Round, 5), -4.5m },
        { 4.45m, new RoundingPolicy(1, 0.1m, RoundingStrategy.Round, 6), 4.4m },
        { -4.45m, new RoundingPolicy(1, 0.1m, RoundingStrategy.Round, 6), -4.4m },

        { 4.45m, new RoundingPolicy(2, 0.25m, RoundingStrategy.UpByStep), 4.50m },
        { -4.45m, new RoundingPolicy(2, 0.25m, RoundingStrategy.UpByStep), -4.50m },

        { 4.45m, new RoundingPolicy(2, 0.25m, RoundingStrategy.DownByStep), 4.25m },
        { -4.45m, new RoundingPolicy(2, 0.25m, RoundingStrategy.DownByStep), -4.25m },

        { 4.45m, new RoundingPolicy(1, 0.1m, RoundingStrategy.TowardsPositive), 4.5m },
        { -4.45m, new RoundingPolicy(1, 0.1m, RoundingStrategy.TowardsPositive), -4.4m },

        { 4.45m, new RoundingPolicy(1, 0.1m, RoundingStrategy.TowardsNegative), 4.4m },
        { -4.45m, new RoundingPolicy(1, 0.1m, RoundingStrategy.TowardsNegative), -4.5m },
    };
}
