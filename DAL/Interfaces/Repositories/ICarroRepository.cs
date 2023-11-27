using ControleEstacionamento.Domain.Entidades;

namespace ControleEstacionamento.Domain.Interfaces.Repositories
{
    public interface ICarroRepository : IRepository<Carro>
    {
        Task<Carro> GetPorPlaca(string placa);
    }
}
