using ControleEstacionamento.Domain.Entidades;

namespace ControleEstacionamento.Domain.Interfaces.Repositories
{
    public interface IRegistroRepository : IRepository<Registro>
    {
        IQueryable<Registro> GetAllMovimentacoes();
        IQueryable<Registro> GetAllEntradas();
        Registro GetByPlaca(string placa);
    }
}
