using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.AspNetCore.Mvc.Versioning;
using Modificabilidade.Application.UseCases.Interfaces;

namespace Modificabilidade.API.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("v{version:apiVersion}/login")]
public class LoginController(IAuthenticatorUsesCase authenticatorUserCase) : ControllerBase
{
    [HttpPost]
    public IActionResult Login([FromBody] LoginRequest request)
    {
        if(authenticatorUserCase.Authenticate(request.Email, request.Password))
            return Ok(new { message = "Login efetuado com sucesso" });
        
        return Unauthorized(new { message = "Email ou senha inválidos" });
    }
}