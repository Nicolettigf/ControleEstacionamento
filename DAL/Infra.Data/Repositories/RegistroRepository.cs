using ControleEstacionamento.Domain.Entidades;
using ControleEstacionamento.Domain.Interfaces.Repositories;
using ControleEstacionamento.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace ControleEstacionamento.Infra.Data.Repositories
{
    public class RegistroRepository : Repository<Registro>, IRegistroRepository
    {
        public RegistroRepository(DataContext context) : base(context)
        {
        }

        public IQueryable<Registro> GetAllMovimentacoes()
        {
            return _context.Set<Registro>().Where(wh => wh.HorarioSaida != null).Include(include => include.Carro);
        }

        public IQueryable<Registro> GetAllEntradas()
        {
            return _context.Set<Registro>().Where(wh => wh.HorarioSaida == null).Include(include => include.Carro);
        }

        public Registro GetByPlaca(string placa)
        {
            return _context.Set<Registro>().Where(wh => wh.Carro.Placa == placa).Include(include => include.Carro).FirstOrDefault();
        }
    }
}
