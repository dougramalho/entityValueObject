using System.Data.Entity.ModelConfiguration;

namespace Repository.Mapping.Common
{
    public abstract class BaseMap<TEntity> : EntityTypeConfiguration<TEntity> where TEntity : class
    {
        protected BaseMap(string nomeTabela)
        {
            ToTable(nomeTabela);

            NomeTabela = nomeTabela;
        }

        public string NomeTabela { get; }
    }
}