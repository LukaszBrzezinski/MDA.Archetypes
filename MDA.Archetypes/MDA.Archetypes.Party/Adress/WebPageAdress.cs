namespace MDA.Archetypes.Party.Adress;

public class WebPageAdress : Address
{
    public string Url { get; }

    private WebPageAdress(string url)
    {
        Url = url;
    }

    public override string GetAddressString() => Url;

    /// <summary>
    /// Creates new <see cref="WebPageAdress"/>.
    /// </summary>
    /// <param name="url">Web page url</param>
    /// <returns><see cref="WebPageAdress"/></returns>
    public static WebPageAdress Create(string url)
    {
        //TODO: Validation logic
        return new WebPageAdress(url);
    }
}