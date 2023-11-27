using ControleEstacionamento.Domain.Entidades;
using ControleEstacionamento.Domain.Interfaces.Repositories;
using ControleEstacionamento.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace ControleEstacionamento.Infra.Data.Repositories
{
    public class CarroRepository : Repository<Carro>, ICarroRepository
    {
        public CarroRepository(DataContext context) : base(context)
        {
        }

        public async Task<Carro> GetPorPlaca(string placa)
        {
            return await _context.Set<Carro>().Where(where => where.Placa == placa).FirstOrDefaultAsync();
        }
    }
}
