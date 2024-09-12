namespace Empresa.Endereco.Servico
{
    public class IdadeService
    {
        public int BuscarIdade (DateTime dataNascimento)
        {
            DateTime data = DateTime.Now;
            int idade = data.Year - dataNascimento.Year;
            if (data.Month<dataNascimento.Month) 
                idade--; 
            return idade;    
        }
    }
}