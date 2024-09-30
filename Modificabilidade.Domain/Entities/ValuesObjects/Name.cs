using Modificabilidade.Domain.Entities.Base;

namespace Modificabilidade.Domain.Entities.ValuesObjects;

public class Name
{
    public string? FirstName { get; private set; }
    public string? LastName { get; private set; }
    
    public Name(string? firstName, string? lastName)
    {
        FirstName = firstName;
        LastName = lastName;
        ValidadeName();
    }

    private void ValidadeName()
    {
        AssertionConcem.VerifyIfIsNull(this.FirstName, "First name is required");
        AssertionConcem.VerifyIfIsNull(this.LastName, "Last name  is required");
        AssertionConcem.VerifyIfIsNull(this, "Name  is required");
    }

}