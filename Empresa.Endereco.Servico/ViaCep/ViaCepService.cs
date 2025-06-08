using Empresa.Endereco.Dominio.Entites;
using Newtonsoft.Json;

namespace Empresa.Endereco.Servico.ViaCep
{
    public class ViaCepService
    {
        public async Task <EnderecoEntity> ObterEnderencoPorCep(string cep)
        {
            var httpClient = new HttpClient();

            var requestReturn = await httpClient.GetAsync($"http://viacep.com.br/ws/{cep}/json");

            if (requestReturn.IsSuccessStatusCode)
            {
                var objetoSerializado = await
                    requestReturn.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<EnderecoEntity>(objetoSerializado);
            }
            return new EnderecoEntity(); 
        }
        public async Task<List<EnderecoEntity>> ObterListaDeEnderecoPorUfCidade(string estado, string cidade)
        {
            var httpClient = new HttpClient();
            var retonroRequisicao = await httpClient.GetAsync($"https://viacep.com.br/ws/{estado}/{cidade}/Rua/json/");

            if (retonroRequisicao.IsSuccessStatusCode)
            {
                var objetoSerializado = await retonroRequisicao.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<EnderecoEntity>>(objetoSerializado);
            }

            return new List<EnderecoEntity>();
        }
    }
}
