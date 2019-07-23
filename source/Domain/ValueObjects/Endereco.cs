namespace Domain.ValueObjects
{
    public class Endereco
    {
        public string Logradouro { get; private set; }
        public string EstadoLogradouro { get; private set; }
        public string CidadeLogradouro { get; private set; }
        
        public Endereco(string logradouro, string estado, string cidade)
        {
            Logradouro = logradouro;
            EstadoLogradouro = estado;
            CidadeLogradouro = cidade;
        }

        public override string ToString()
        {
            return $"${Logradouro}, ${CidadeLogradouro}, ${EstadoLogradouro}";
        }
    }
}