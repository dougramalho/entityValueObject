using System;
using System.Collections.Generic;
using Domain.Identities;
using Domain.ValueObjects;

namespace Domain.Entities
{
    public class Pessoa
    {
        public Guid Id { get; protected set; }
        //public Guid Id { get; protected set; }
        public string Nome { get; private set; }
        public Cpf Cpf { get; private set; }
        public DadosComplementares DadosComplementares { get; private set; }
        
        public Pessoa(PessoaId id, string nome, Cpf cpf, DadosComplementares dadosBasicos)
        {
            //Id = id;
            Id = id.Value;
            Nome = nome;
            Cpf = cpf;
            DadosComplementares = dadosBasicos;
        }
    }
}