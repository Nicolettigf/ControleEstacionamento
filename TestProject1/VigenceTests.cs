using BLL.Interfaces;
using ControleEstacionamento.Application.Services;
using ControleEstacionamento.Domain.Entidades;
using ControleEstacionamento.Domain.Interfaces.Repositories;
using ControleEstacionamento.Infra.Data;
using Entities;
using Moq;
using Xunit;

namespace TestProject1
{
    public class VigenceTests
    {
        [Fact]
        public async Task TesteGetInstance()
        {
            var Unit = new Mock<IUnitOfWork>();
            var repository = new Mock<IVigenciaPrecoRepository>();

            var vigencia = new VigenciaPreco().ReturnDefault();

            repository.Setup(r => r.GetInstance()).ReturnsAsync(vigencia);

            var meuServicoMock = new Mock<IVigenciaAppService>();
            meuServicoMock.Setup(s => s.GetInstance()).ReturnsAsync(ResponseFactory.CreateInstance()
                .CreateSingleSuccessResponse<VigenciaPreco>(vigencia));

            var classeQueUsaServico = new VigenciaAppService(Unit.Object, repository.Object);

            var resultado = await classeQueUsaServico.GetInstance();

            Assert.Equal(vigencia, resultado.Item);
        }
    }
}