using System.Text;

namespace MDA.Archetypes.Party.Adress;

internal class GeographicAddress : Address
{
    public IReadOnlyList<string> AddressLines { get; }
    public string City { get; }
    public string RegionOrState { get; }
    public string ZipOrPostCode { get; }
    public IsoCountryCode Country { get; }

    private GeographicAddress(
        IReadOnlyList<string> addressLines,
        string city,
        string regionOrState,
        string zipOrPostCode,
        IsoCountryCode country)
    {
        AddressLines = addressLines;
        City = city;
        RegionOrState = regionOrState;
        ZipOrPostCode = zipOrPostCode;
        Country = country;
    }

    public override string GetAddressString()
    {
        var sb = new StringBuilder();

        foreach (var line in AddressLines)
        {
            sb.AppendLine(line);
        }

        sb.AppendLine($"{City}, {ZipOrPostCode}");
        sb.AppendLine($"{RegionOrState}, {Country.Name} {Country.TwoLetterCode}");

        return sb.ToString();
    }

    /// <summary>
    /// Creates new <see cref="GeographicAddress"./>
    /// </summary>
    /// <param name="city">The name of a city or town</param>
    /// <param name="regionOrState">Name of geographical region within a country</param>
    /// <param name="zipOrPostCode">Code used to identify a geographic area</param>
    /// <param name="country"></param>
    /// <param name="addressLines">One ore more address lines. First is often a building name, 
    /// a building numer and street, or a postal box number; the other address lines are for 
    /// location information that is best placed on its own line</param>
    /// <returns></returns>
    public GeographicAddress Create(
        string city,
        string regionOrState,
        string zipOrPostCode,
        IsoCountryCode country,
        params string[] addressLines)
    {
        //TODO: Add validation
        return new GeographicAddress(addressLines, city, regionOrState, zipOrPostCode, country);
    }
}
