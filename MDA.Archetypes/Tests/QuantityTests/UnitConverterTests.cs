using FluentAssertions;
using MDA.Archetypes.Quantity;
using MDA.Archetypes.Quantity.UnitConversion;
using MDA.Archetypes.Quantity.Units;

namespace QuantityTests;

public class UnitConverterTests
{
    private readonly UnitConverter _unitConverter;
    public UnitConverterTests()
    {
        var conversion = new StandardConversion(0.9144m, ImperialBaseUnit.Yard, SiBaseUnit.Meter);
        _unitConverter = new UnitConverter([conversion]);
    }

    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 0.9144)]
    [InlineData(10000, 9144)]
    [InlineData(-1, -0.9144)]
    [InlineData(1628, 1_488.6432)]
    public void Convert_WhenStandardConversionExist_ReturnsValidResult(decimal quantityValue, decimal expectedResult)
    {
        var quantity = new Quantity(quantityValue, ImperialBaseUnit.Yard);

        var result = _unitConverter.Convert(quantity, SiBaseUnit.Meter);

        result.Should().Be(new Quantity(expectedResult, SiBaseUnit.Meter));
    }

    [Fact]
    public void Convert_WhenStandardConversionDoNotExist_ThrowException()
    {
        var quantity = new Quantity(1, SiBaseUnit.Meter);

        var act = () => _unitConverter.Convert(quantity, ImperialBaseUnit.Yard);

        act.Should()
            .Throw<ConversionException>()
            .WithMessage("Could not convert Meter to Yard. Standard conversion missing.");
    }

    [Fact]
    public void Convert_WhenSourceAndTargetUnitAreSame_RetrunSameQuantity()
    {
        var quantity = new Quantity(1, SiBaseUnit.Meter);

        var result = _unitConverter.Convert(quantity, SiBaseUnit.Meter);

        result.Should().Be(quantity);
    }

    [Fact]
    public void Convert_WhenQuantityNull_ThrowException()
    {
        var act = () => _unitConverter.Convert(null!, SiBaseUnit.Meter);

        act.Should().Throw<ArgumentNullException>();
    }

    [Fact]
    public void Convert_WhenUnitNull_ThrowException()
    {
        var quantity = new Quantity(1, SiBaseUnit.Meter);

        var act = () => _unitConverter.Convert(quantity, null!);

        act.Should().Throw<ArgumentNullException>();
    }
}