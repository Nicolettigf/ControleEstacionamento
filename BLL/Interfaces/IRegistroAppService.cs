using ControleEstacionamento.Application.DTOs;
using ControleEstacionamento.Domain.Entidades;
using Shared;

namespace BLL.Interfaces
{
    public interface IRegistroAppService
    {
        public Task<Response> Create(Registro vigencia);
        
        public Task<Response> UpdateRegistro(string placa, DateTime now, decimal valorHora);

        public Task<DataResponse<RegistroDTO>> GetAllMovimentacoes();

        public Task<DataResponse<RegistroDTO>> GetAllEntradas();

        public Task<DataResponse<string>> GetListCars();
    }
}
