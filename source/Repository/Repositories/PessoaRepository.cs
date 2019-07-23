using System.Data.Entity;
using Domain.Entities;
using Domain.Repositories;

namespace Repository.Repositories
{
    public class PessoaRepository : IPessoaRepository
    {
        protected DbContext Context { get; }
        
        public PessoaRepository(DbContext db)
        {
            Context = db;
        }
        
        public void Cadastrar(Pessoa pessoa)
        {
            Context.Set<Pessoa>().Add(pessoa);
            Context.SaveChanges();
        }
    }
}

