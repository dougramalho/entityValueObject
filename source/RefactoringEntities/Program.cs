using System;
using System.Collections.Generic;
using Domain.Entities;
using Domain.Identities;
using Domain.ValueObjects;
using Repository.Context;
using Repository.Repositories;

namespace RefactoringEntities
{
    internal class Program
    {
        public static void Main(string[] args)
        {
//            var cpf = "";
//
//            var isValido = Util.ValidaCpf(cpf);
//            if (isValido)
//            {
////                var pessoa = new Pessoa()
////                {
////                    CPF = cpf
////                };
//            }
//            else
//            {
//                throw new Exception("CPF informado está inválido");
//            }

            var pessoaRepository = new PessoaRepository(new RefactoringDbContext());
            pessoaRepository.SalvarPessoa(new Pessoa(
                new PessoaId(Guid.NewGuid()), "Douglas José Ramalho", 
                new Cpf("02866783140"), 
                new DadosComplementares("919394", DateTime.Now, "MinhaMae", 
                    new Endereco("SGAN 911", "Tocantins", "Palmas"), 
                    new Contato(new Email("doug.ramalho@gmail.com"), 
                        new List<string>(){"32145552"} ) )));

        }
    }
}