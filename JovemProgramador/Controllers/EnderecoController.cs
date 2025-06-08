using Empresa.Endereco.Servico.ViaCep;
using Microsoft.AspNetCore.Mvc;

namespace Empresa.Endereco.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnderecoController:ControllerBase
    {
        [HttpGet(Name = "GetEnderecoPorCep")]
        public async Task<IActionResult> ObterEnderecos(string cep)
        {
            var requisicao = await new ViaCepService().ObterEnderencoPorCep(cep);
            return Ok(requisicao);  
        }

    }
}
