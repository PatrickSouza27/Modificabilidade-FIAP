namespace Modificabilidade.Domain.Entities.Base;

public static class AssertionConcem
{
    public static void AssertArgumentLength(string value, int maximum, string message)
    {
        var length = value.Trim().Length;
        if (length > maximum)
            throw new DomainException(message);
    }
    
    public static void AssertArgumentLength(string value, int minimum, int max, string message)
    {
        var length = value.Trim().Length;
        if (length < minimum || length > max)
            throw new DomainException(message);
    }
    
    public static void VerifyIfTrue(bool value, string message)
    {
        if (value)
            throw new DomainException(message);
    }
    
    public static void VerifyIfIsNull(object? value, string message)
    {
        if (value is null)
            throw new DomainException(message);
    }
}