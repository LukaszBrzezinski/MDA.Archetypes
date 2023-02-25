namespace MDA.Archetypes.Party.Adress
{
    public abstract class Address
    {
        public DateOnly ValidFrom { get; }
        public DateOnly ValidTo { get; private set; }
        public abstract string GetAddressString();

        public Address(DateOnly validFrom, DateOnly validTo)
        {
            ValidTo = validTo;
            ValidFrom = validFrom;
        }

        public void Invalidate(DateOnly validTo)
        {
            ValidTo = validTo;
        }
    }
}