using MDA.Archetypes.Party.Adress;

namespace MDA.Archetypes.Party
{
    public record PartyId(Guid Value)
    {
        public static PartyId New()
        {
            return new PartyId(Guid.NewGuid());
        }
    }

    public abstract class Party
    {
        public PartyId Id { get; }
        public string Name { get; }
        public IEnumerable<Address> Addresses => _addresses.AsReadOnly();
        private List<Address> _addresses;

    }
}