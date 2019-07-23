using System;

namespace Domain.ValueObjects
{
    public class DadosComplementares
    {
        public string RG { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public string NomeMae { get; private set; }
        
        public Endereco Endereco { get; private set; }
        
        public Contato Contato { get; private set; }
        
        public DadosComplementares(string rg, DateTime dataNascimento, string nomeMae, Endereco endereco, Contato contato)
        {
            RG = rg;
            DataNascimento = dataNascimento;
            NomeMae = nomeMae;
            Endereco = endereco;
            Contato = contato;
        }
    }
}