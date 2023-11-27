using AutoMapper;
using BLL.Interfaces;
using ControleEstacionamento.Application.DTOs;
using ControleEstacionamento.Domain.Entidades;
using ControleEstacionamento.Domain.Interfaces.Repositories;
using ControleEstacionamento.Infra.Data.Repositories;
using DAL.Interfaces.Repositories;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Shared;
using System.Linq.Expressions;

namespace ControleEstacionamento.Application.Services
{
    public class RegistroAppService : IRegistroAppService
    {
        private readonly ICarroRepository _carroRepository;
        private readonly IRegistroRepository _registroRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IMemoryCache _memoryCache;



        public RegistroAppService(IMapper mapper,ICarroRepository carroRepository, 
            IRegistroRepository registroAppService, IUnitOfWork unitOfWork, IMemoryCache memoryCache)
        {
            _mapper = mapper;
            _memoryCache = memoryCache;
            _unitOfWork = unitOfWork;
            _registroRepository = registroAppService;
            _carroRepository = carroRepository;
        }

        public async Task<DataResponse<RegistroDTO>> GetAllMovimentacoes()
        {
            const string cacheKey = "Movimentacoes";
            var registro = new List<Registro>();
            if (_memoryCache.TryGetValue(cacheKey, out List<Registro> dados))
            {
                registro = dados;
            }
            else { registro = await _registroRepository.GetAllMovimentacoes().ToListAsync(); }
                
            var entidades = _mapper.Map<List<RegistroDTO>>(registro);

            var cacheEntryOptions = new MemoryCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(3),
            };
            _memoryCache.Set(cacheKey, registro, cacheEntryOptions);


            return ResponseFactory.CreateInstance().CreateDataSuccessResponse<RegistroDTO>(entidades);
        }

        public async Task<DataResponse<RegistroDTO>> GetAllEntradas()
        {
            const string cacheKey = "Entradas";
            var registro = new List<Registro>();
            if (_memoryCache.TryGetValue(cacheKey, out List<Registro> dados))
            {
                registro = dados;
            }
            else { registro = await _registroRepository.GetAllEntradas().ToListAsync(); }

            var entidades = _mapper.Map<List<RegistroDTO>>(registro);

            var cacheEntryOptions = new MemoryCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(3),
            };
            _memoryCache.Set(cacheKey, registro, cacheEntryOptions);

            return ResponseFactory.CreateInstance().CreateDataSuccessResponse<RegistroDTO>(entidades);
        }

        public async Task<Response> Create(Registro dto)
        {
            var carro = await _carroRepository.GetPorPlaca(dto.Carro.Placa);

            if (carro == null)
                dto.Carro = new Carro(dto.Carro.Placa);
            else
                dto.CarroId = carro.Id;
            try
            {
                _registroRepository.Create(dto);
                _unitOfWork.Commit();
                return ResponseFactory.CreateInstance().CreateSuccessResponse();
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateInstance().CreateFailedResponse(ex.Message);
            }
        }

        public async Task<Response> UpdateRegistro(string placa, DateTime saida,decimal valorTotal)
        {
            var entidade = _registroRepository.GetByPlaca(placa);
            entidade.MarcarHorarioSaida(saida, valorTotal);

            _registroRepository.Update(entidade);
            _unitOfWork.Commit();
            return ResponseFactory.CreateInstance().CreateSuccessResponse();
        }

        public async Task<DataResponse<string>> GetListCars()
        {
            var list = await _carroRepository.GetAll().Select(se => se.Placa).ToListAsync();
            return ResponseFactory.CreateInstance().CreateDataSuccessResponse(list);
        }
    }
}
