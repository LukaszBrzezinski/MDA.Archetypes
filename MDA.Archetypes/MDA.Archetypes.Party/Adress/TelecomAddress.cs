namespace MDA.Archetypes.Party.Adress;

public class TelecomAddress : Address
{
    public string CountryCode { get; }
    public string NationalDirectDialingPrefix { get; }
    public string AreaCode { get; }
    public string Number { get; }
    public string Extension { get; }
    public string PhysicalType { get; }

    public override string GetAddressString()
    {
        return $"{PhysicalType} +{CountryCode}({NationalDirectDialingPrefix}){AreaCode}{Number} ext. {Extension}";
    }

    private TelecomAddress(string countryCode,
        string nationalDirectDialingPrefix,
        string areaCode,
        string number,
        string extension,
        string physicalType)
    {
        CountryCode = countryCode;
        NationalDirectDialingPrefix = nationalDirectDialingPrefix;
        AreaCode = areaCode;
        Number = number;
        Extension = extension;
        PhysicalType = physicalType;
    }

    /// <summary>
    /// Creates <see cref="TelecomAddress"/>.
    /// </summary>
    /// <param name="countryCode">Country code ISO 3166</param>
    /// <param name="nationalDirectDialingPrefix">prefix to make call within a countrybetween different cities or areas.</param>
    /// <param name="areaCode">code for area or city</param>
    /// <param name="number">telephone number</param>
    /// <param name="extension">an extension accessible via the number</param>
    /// <param name="physicalType">type of device acessed by the <see cref="TelecomAddress"/> example phone, mobile, fax, pager</param>
    /// <returns></returns>
    public static TelecomAddress Create(string countryCode,
        string nationalDirectDialingPrefix,
        string areaCode,
        string number,
        string extension,
        string physicalType)
    {
        return new TelecomAddress(
            countryCode,
            nationalDirectDialingPrefix,
            areaCode,
            number,
            extension,
            physicalType;
    }
}