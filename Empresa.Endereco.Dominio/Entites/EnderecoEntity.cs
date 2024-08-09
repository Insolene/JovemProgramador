namespace Empresa.Endereco.Dominio.Entites
{
    public class EnderecoEntity
    {
        public string cep { get; set; }
        public string longradouro { get; set; }
        public string localidade { get; set; }  

        public EnderecoEntity()
        {

        }

        public EnderecoEntity(string cep, string longradouro, string localidade)
        {
            this.cep = cep;
            this.longradouro = longradouro;
            this.localidade = localidade;
        }
    }
}
