using MDA.Archetypes.Party.Adress;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDA.Archetypes.Party.Person
{
    public class Person : Party
    {
        public DateOnly DateOfBirth { get; }
        public IsoGender Gender { get; }
        public Person(PartyId id, string name, IEnumerable<Address> addresses) : base(id, name, addresses)
        {
        }

        
    }
}
