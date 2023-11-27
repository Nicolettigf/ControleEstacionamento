using BLL.Interfaces;
using ControleEstacionamento.Application.Mappers.Profiles;
using ControleEstacionamento.Application.Services;
using ControleEstacionamento.Domain.Interfaces.Repositories;
using ControleEstacionamento.Infra.Data.Context;
using ControleEstacionamento.Infra.Data.Repositories;
using DAL.Infra.Data.Context;
using DAL.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Windows.Forms;

namespace PresetationLayer
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Configuração do serviço
            var serviceProvider = ConfigureServices();

            // Use o serviço para obter o DataContext
            var dbContext = serviceProvider.GetService<DataContext>();

            // Restante do código
            ApplicationConfiguration.Initialize();
            Application.Run(new MenuGeral(serviceProvider));
        }

        static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddAutoMapper(typeof(RegistroProfile));
            services.AddMemoryCache();

            // Dependency Injection
            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(ICarroRepository), typeof(CarroRepository));
            services.AddScoped(typeof(IRegistroRepository), typeof(RegistroRepository));
            services.AddScoped(typeof(IVigenciaPrecoRepository), typeof(VigenciaPrecoRepository));
            services.AddScoped(typeof(IRegistroAppService), typeof(RegistroAppService));
            services.AddScoped(typeof(IVigenciaAppService), typeof(VigenciaAppService));

            services.AddDbContext<DataContext>(options =>
        options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=msdb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"));


            // Construir o provedor de serviços
            return services.BuildServiceProvider();
        }
    }
}