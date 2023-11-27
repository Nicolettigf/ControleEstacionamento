using ControleEstacionamento.Domain.Entidades;
using ControleEstacionamento.Domain.Interfaces.Repositories;
using ControleEstacionamento.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace ControleEstacionamento.Infra.Data.Repositories
{
    public class VigenciaPrecoRepository : Repository<VigenciaPreco>, IVigenciaPrecoRepository
    {
        public VigenciaPrecoRepository(DataContext context) : base(context)
        {
        }

        public async Task<VigenciaPreco> GetInstance()
        {
            return await _context.Set<VigenciaPreco>().FirstOrDefaultAsync();
        }
    }
}
