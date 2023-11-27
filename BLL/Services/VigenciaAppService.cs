using BLL.Interfaces;
using ControleEstacionamento.Domain.Entidades;
using ControleEstacionamento.Domain.Interfaces.Repositories;
using DAL.Interfaces.Repositories;
using Entities;
using Shared;

namespace ControleEstacionamento.Application.Services
{
    public class VigenciaAppService : IVigenciaAppService
    {
        private readonly IVigenciaPrecoRepository _vigenciaRepository;
        private readonly IUnitOfWork _unitOfWork;

        public VigenciaAppService(IUnitOfWork unitOfWork, IVigenciaPrecoRepository vigenciaRepository)
        {
            _vigenciaRepository = vigenciaRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<SingleResponse<VigenciaPreco>> GetInstance()
        {
            try
            {
                var vigencia = await _vigenciaRepository.GetInstance();
                return ResponseFactory.CreateInstance().CreateSingleSuccessResponse<VigenciaPreco>(vigencia);
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateInstance().CreateSingleFailedResponse<VigenciaPreco>(ex.Message, null);
            }
        }

        public async Task<Response> Create(VigenciaPreco vigencia)
        {
            if (vigencia.InicioVigencia >= vigencia.FimVigencia)
            {
                return ResponseFactory.CreateInstance()
                .CreateFailedResponse("Inicio da Vigencia tem que ser maior que o final da mesma");
                //Continuação de regra de negocio
            }

            try
            {
                _vigenciaRepository.Create(vigencia);
                _unitOfWork.Commit();
                return ResponseFactory.CreateInstance().CreateSuccessResponse();
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateInstance().CreateFailedResponse(ex.Message);
            }
        }

        public async Task<Response> UpdateInstance(VigenciaPreco vigencia)
        {
            if (vigencia.InicioVigencia >= vigencia.FimVigencia)
            {
                return ResponseFactory.CreateInstance()
                .CreateFailedResponse("Inicio da Vigencia tem que ser maior que o final da mesma");
                //Continuação de regra de negocio
            }

            try
            {
                var singleVigence = await GetInstance();
                var vigence = singleVigence.Item;   
                vigence.UpdateVigenceItens(vigencia);

                _vigenciaRepository.Update(vigence);
                _unitOfWork.Commit();
                return ResponseFactory.CreateInstance().CreateSuccessResponse();
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateInstance().CreateFailedResponse(ex.Message);
            }
        }
    }
}
