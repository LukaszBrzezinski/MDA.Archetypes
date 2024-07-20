using MDA.Archetypes.Party.Adress;

namespace MDA.Archetypes.Party.Person;

public class Person : Party
{
    public DateOnly DateOfBirth { get; }
    public IsoGender Gender { get; }
    private readonly Name _name;
    public Person(PartyId id, Name name, IEnumerable<Address> addresses) : base(id, name.ToString(), addresses)
    {
        _name = name;
    }


}
