namespace Modificabilidade.Domain.Repositories;

public interface IAuthenticatorRepository
{
    bool Authenticator(string email, string password);
}