namespace Modificabilidade.Application.UseCases.Interfaces;

public interface IAuthenticatorUsesCase
{
    bool Authenticate(string email, string password);
}