namespace Modificabilidade.Domain.Entities.ValuesObjects;

public class Email(string address) : ValueObject
{
    public string Address { get; private set; } = address;
}