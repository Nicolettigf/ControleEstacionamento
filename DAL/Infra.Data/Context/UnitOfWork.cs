using ControleEstacionamento.Infra.Data.Context;
using DAL.Interfaces.Repositories;

namespace DAL.Infra.Data.Context
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;

        public UnitOfWork(DataContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Rollback()
        {
            // doNothing
        }
    }
}
