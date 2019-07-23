using System.Data.Entity.Core.Metadata.Edm;
using Domain.Entities;
using Repository.Mapping.Common;

namespace Repository.Mapping
{
    public class PessoaMap : BaseMap<Pessoa>
    {
        public PessoaMap() : base("TB_PESSOA")
        {
            //HasKey(x => x.Id.Value);
            
            
            
            Property(x => x.Id).HasColumnName("Id").IsRequired();
            Property(x => x.Nome).HasColumnName("Nome").IsRequired();
            Property(x => x.Cpf.Value).HasColumnName("Cpf_Value").IsRequired();
            Property(x => x.DadosComplementares.RG).HasColumnName("DadosComplementares_Rg").IsRequired();
            Property(x => x.DadosComplementares.DataNascimento).HasColumnName("DadosComplementares_DataNascimento").IsRequired();
            Property(x => x.DadosComplementares.NomeMae).HasColumnName("DadosComplementares_NomeMae").IsRequired();
            Property(x => x.DadosComplementares.Endereco.Logradouro).HasColumnName("DadosComplementares_Endereco_Logradouro").IsRequired();
            Property(x => x.DadosComplementares.Endereco.EstadoLogradouro).HasColumnName("DadosComplementares_Endereco_EstadoLogradouro").IsRequired();
            Property(x => x.DadosComplementares.Endereco.CidadeLogradouro).HasColumnName("DadosComplementares_Endereco_CidadeLogradouro").IsRequired();
            Property(x => x.DadosComplementares.Contato.Telefones).HasColumnName("DadosComplementares_Contato_Telefones").IsRequired();
            Property(x => x.DadosComplementares.Contato.Email.Endereco).HasColumnName("DadosComplementares_Contato_Email").IsRequired();
        }
    }
}