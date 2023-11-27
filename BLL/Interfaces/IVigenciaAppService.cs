using ControleEstacionamento.Domain.Entidades;
using Shared;

namespace BLL.Interfaces
{
    public interface IVigenciaAppService
    {
        public Task<Response> Create(VigenciaPreco vigencia);
        public Task<Response> UpdateInstance(VigenciaPreco vigencia);

        public Task<SingleResponse<VigenciaPreco>> GetInstance();
    }
}
