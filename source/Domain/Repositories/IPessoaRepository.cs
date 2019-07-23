using Domain.Entities;

namespace Domain.Repositories
{
    public interface IPessoaRepository
    {
        void Cadastrar(Pessoa pessoa);
    }
}