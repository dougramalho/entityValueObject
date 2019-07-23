using System;
using System.Security.Authentication;
using Domain.Exceptions;
using Domain.ValueObjects;
using Xunit;

namespace Domain.Tests.ValueObjects
{
    public class Cpf_Tests
    {
        [Fact]
        public void DeveAceitarCpfValido()
        {
            var cpf = new Cpf("36122375004");
            Assert.Equal("36122375004",cpf.Value);
        }
        
        [Fact]
        public void DeveFormatarCpf()
        {
            var cpf = new Cpf("36122375004");
            Assert.Equal("361.223.750-04",cpf.ObterCpfComMascara());
        }

        [Fact]
        public void NaoDeveAceitarCpfInvalido()
        {
            Exception ex = Assert.Throws<CpfInvalidoException>(() => new Cpf("16222375004"));
            Assert.Equal("O cpf informado é inválido.", ex.Message);
        }

        [Fact]
        public void NaoDeveAceitarCpfEmBranco()
        {
            Exception ex = Assert.Throws<CpfEmBrancoException>(() => new Cpf(string.Empty));
            Assert.Equal("O cpf não pode ser vazio.", ex.Message);
        }
      
        
    }
}