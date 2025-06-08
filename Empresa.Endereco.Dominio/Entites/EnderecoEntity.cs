﻿namespace Empresa.Endereco.Dominio.Entites
{
    public class EnderecoEntity
    {
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string bairro { get; set; }
        public string localidade { get; set; }
        public string uf { get; set; }

        public EnderecoEntity() { }

        public EnderecoEntity(string cep, string logradouro, string bairro, string localidade, string uf)
        {
            this.cep = cep;
            this.logradouro = logradouro;
            this.bairro = bairro;
            this.localidade = localidade;
            this.uf = uf;
        }
    }
}
