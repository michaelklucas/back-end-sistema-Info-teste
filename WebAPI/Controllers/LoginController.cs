using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebAPI.Models;
using WebAPI.Token;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
     

        [AllowAnonymous]
        [Produces("application/json")]
        [HttpPost("/api/CriarToken")]
        public async Task<IActionResult> CriarToken([FromBody] Login login)
        {
            if (string.IsNullOrWhiteSpace(login.email) || string.IsNullOrWhiteSpace(login.senha))
                return Unauthorized();

            if (login.email == "SISTEMA" && login.senha == "candidato123")
            {
                
                var token = new TokenJWTBuilder()
                     .AddSecurityKey(JwtSecurityKey.Create("Secret_Key-12345678"))
                     .AddSubject("Empresa - Canal Dev Net Core")
                     .AddIssuer("Teste.Securiry.Bearer")
                     .AddAudience("Teste.Securiry.Bearer")
                     .AddExpiry(5)
                     .Builder();

                return Ok(token.value);
            }
            else
            {
                return Unauthorized();
            }
        }


        [AllowAnonymous]
        [Produces("application/json")]
        [HttpPost("/api/CriarTokenIdentity")]
        public async Task<IActionResult> CriarTokenIdentity([FromBody] Login login)
        {
            if (string.IsNullOrWhiteSpace(login.email) || string.IsNullOrWhiteSpace(login.senha))
                return Unauthorized();

            if (login.email == "SISTEMA" && login.senha == "candidato123")
            {
   
                var token = new TokenJWTBuilder()
                     .AddSecurityKey(JwtSecurityKey.Create("Secret_Key-12345678"))
                     .AddSubject("Empresa - Canal Dev Net Core")
                     .AddIssuer("Teste.Securiry.Bearer")
                     .AddAudience("Teste.Securiry.Bearer")
                     .AddExpiry(5)
                     .Builder();

                return Ok(token.value);
            }
            else
            {
                return Unauthorized();
            }
        }
    }
}
