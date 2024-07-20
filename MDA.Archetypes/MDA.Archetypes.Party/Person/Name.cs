using System.Text;

namespace MDA.Archetypes.Party.Person;

/// <summary>
/// Represents a name for a Person. Each person could have only one legal name at any point in time.
/// </summary>
/// <param name="GivenName">First name (in western countries)</param>
/// <param name="FamilyName">Last name (in western countries)</param>
/// <param name="Prefix">An honorific such as Mr, Miss, Dr.</param>
/// <param name="MiddleName">Any name other than the given name and the family name</param>
/// <param name="Suffix">suffix may be: generational label (Jr., III), qualification (Ph. D., BSc), title (FRSC Fellow of the Royal Society of Chemestry, KG Knight of the Garter)</param>
public record Name(string GivenName, string FamilyName, string? Prefix = null, string? MiddleName = null, string? Suffix = null)
{
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendFormat("{0} ", Prefix);
        sb.AppendFormat("{0} ", GivenName);
        sb.AppendFormat("{0} ", MiddleName);
        sb.AppendFormat("{0} ", FamilyName);
        sb.AppendFormat("{0} ", Suffix);

        return sb.ToString();
    }
}
