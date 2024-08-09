using Empresa.Endereco.Dominio.Entites;
using Newtonsoft.Json;

namespace Empresa.Endereco.Servico.ViaCep
{
    public class ViaCepService
    {
        //Função assincrona que ira comunicar com o servidor da viacep 
        public async Task <EnderecoEntity> obterEnderencoPorCep(string cep)
        {
            // Abrindo uma comunicação de protocolo HTTP para comunicar com outro servidor. 
            var httpClient = new HttpClient();

            // Executando a operação de requisiçao para a rota da ViaCep, passando o Cep de forma dinamica utilizando formatalçao de string
            var requestReturn = await httpClient.GetAsync($"http://viacep.com.br/ws/{cep}/json");

            //verificando se a requisição respondeu com sucesso (status code 200) 
            if (requestReturn.IsSuccessStatusCode)
            {
                var objetoSerializado = await
                    requestReturn.Content.ReadAsStringAsync();

                //Comando para desserializar o objeto serializado, recupetrando do retorno da requsição da ViaCep
                return JsonConvert.DeserializeObject<EnderecoEntity>(objetoSerializado);
            }
            return new EnderecoEntity(); 
        }
    }
}
