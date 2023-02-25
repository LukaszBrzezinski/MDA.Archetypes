namespace MDA.Archetypes.Party.Adress
{
    public class WebPageAdress : Address
    {
        public string Url { get; }

        private WebPageAdress(string url, DateOnly validFrom, DateOnly validTo): base(validFrom, validTo)
        {
            Url = url;
        }

        public override string GetAddressString() => Url;

        /// <summary>
        /// Creates new <see cref="WebPageAdress"/> valid from now to infinity.
        /// </summary>
        /// <param name="url">Web page url</param>
        /// <returns><see cref="WebPageAdress"/></returns>
        public static WebPageAdress Create(string url)
        {
            return new WebPageAdress(url, DateOnly.FromDateTime(DateTime.Now), DateOnly.MaxValue);
        }

        /// <summary>
        /// Creates <see cref="WebPageAdress"/> valid in range of dates
        /// </summary>
        /// <param name="url">Web page url</param>
        /// <param name="validFrom">valid from date</param>
        /// <param name="validTo">valid to date</param>
        /// <returns><see cref="WebPageAdress"/></returns>
        public static WebPageAdress Create(string url, DateOnly validFrom, DateOnly validTo)
        {
            return new WebPageAdress(url, validFrom, validTo);
        }
    }

    public class TelecomAddress : Address
    {

    }
}