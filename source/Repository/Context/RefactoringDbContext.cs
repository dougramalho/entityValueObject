using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Diagnostics;
using Domain.Entities;

namespace Repository.Context
{
    public class RefactoringDbContext : DbContext
    {
        public RefactoringDbContext() : base("RefactoringDbContext")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
            Configuration.UseDatabaseNullSemantics = true;
            Database.SetInitializer<RefactoringDbContext>(null);

            Database.Log = s => Debug.WriteLine(s);
        }
        
        public virtual DbSet<Pessoa> Pessoa { get; set; }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.Conventions.Remove<PluralizingTableNameConvention>();
            builder.Entity<Pessoa>().ToTable("TB_PESSOA");
            
            builder.Entity<Pessoa>()
                .Property(x => x.Id)
                .HasColumnName("PessoaId_Value");
            
            builder.Entity<Pessoa>()
                .Property(x => x.Cpf.Value)
                .HasColumnName("Cpf_Value");
            
            builder.Entity<Pessoa>()
                .Property(x => x.DadosComplementares.RG)
                .HasColumnName("DadosComplementares_Rg");
            
            builder.Entity<Pessoa>()
                .Property(x => x.DadosComplementares.DataNascimento)
                .HasColumnName("DadosComplementares_DataNascimento");
            
            builder.Entity<Pessoa>()
                .Property(x => x.DadosComplementares.NomeMae)
                .HasColumnName("DadosComplementares_NomeMae");
            
            builder.Entity<Pessoa>()
                .Property(x => x.DadosComplementares.Endereco.Logradouro)
                .HasColumnName("DadosComplementares_Endereco_Logradouro");
            
            builder.Entity<Pessoa>()
                .Property(x => x.DadosComplementares.Endereco.EstadoLogradouro)
                .HasColumnName("DadosComplementares_Endereco_EstadoLogradouro");
            
            builder.Entity<Pessoa>()
                .Property(x => x.DadosComplementares.Endereco.CidadeLogradouro)
                .HasColumnName("DadosComplementares_Endereco_CidadeLogradouro");
            
            builder.Entity<Pessoa>()
                .Property(x => x.DadosComplementares.Contato.Telefones)
                .HasColumnName("DadosComplementares_Contato_Telefones");
            
            builder.Entity<Pessoa>()
                .Property(x => x.DadosComplementares.Contato.Email.Endereco)
                .HasColumnName("DadosComplementares_Contato_Email");

            builder.Entity<Pessoa>().HasKey(x => x.Id);
        }
    }
}