using Empresa.Endereco.Servico;
using Empresa.Endereco.Servico.ViaCep;
using Microsoft.AspNetCore.Mvc;

namespace Empresa.Endereco.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IdadeController:ControllerBase
    {   
        [HttpGet(), Route("ObterIdade")]    
        public IActionResult ObterIdade(DateTime dataNascimento)
        {
            int idade = new IdadeService().BuscarIdade(dataNascimento);
            return Ok(idade); 
        }

    }
}
