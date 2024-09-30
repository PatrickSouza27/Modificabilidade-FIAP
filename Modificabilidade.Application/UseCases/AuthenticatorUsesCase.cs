using Modificabilidade.Application.UseCases.Interfaces;
using Modificabilidade.Domain.Repositories;

namespace Modificabilidade.Application.UseCases;

public class AuthenticatorUsesCase(IAuthenticatorRepository iAuthenticatorRepository) : IAuthenticatorUsesCase
{
    public bool Authenticate(string email, string password)
    {
        return iAuthenticatorRepository.Authenticator(email, password);
    }
}