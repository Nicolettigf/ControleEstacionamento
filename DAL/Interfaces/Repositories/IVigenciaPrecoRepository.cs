using ControleEstacionamento.Domain.Entidades;

namespace ControleEstacionamento.Domain.Interfaces.Repositories
{
    public interface IVigenciaPrecoRepository : IRepository<VigenciaPreco>
    {
        Task<VigenciaPreco> GetInstance();
    }
}
