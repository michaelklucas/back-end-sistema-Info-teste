using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Sistema_Info_Teste.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormController : ControllerBase
    {
        [HttpPost]
        public IActionResult SaveUser(UserModel model)
        {
            // Verifique se os campos obrigatórios estão preenchidos
            if (string.IsNullOrEmpty(model.nome) || string.IsNullOrEmpty(model.cpf))
            {
                return BadRequest("O nome e o CPF são campos obrigatórios.");
            }

            string partCpf = model.cpf.Substring(0, 4);
            string codigo = model.codigo;

            string responseMessage = $"{partCpf}{codigo}";

            var response = new { mensagem = responseMessage };

            // Retorne o objeto JSON
            return Ok(response);
        }
    }
}
