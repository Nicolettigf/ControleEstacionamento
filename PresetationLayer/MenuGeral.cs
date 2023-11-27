using BLL.Interfaces;
using ControleEstacionamento.Domain.Interfaces.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace PresetationLayer
{
    public partial class MenuGeral : Form
    {
        private readonly IVigenciaAppService _vigenciaAppService;
        private readonly IRegistroAppService _registroAppService;

        public MenuGeral(IServiceProvider serviceProvider)
        {
            _vigenciaAppService = serviceProvider.GetService<IVigenciaAppService>();
            _registroAppService = serviceProvider.GetService<IRegistroAppService>();


            InitializeComponent();


            DateAndHourLabel.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }

        private void VigenciaButton_Click(object sender, EventArgs e)
        {
            FormAlterarVigencia form = new FormAlterarVigencia(_vigenciaAppService);
            form.ShowDialog();
        }

        private async void MarcarEntradaButton_Click(object sender, EventArgs e)
        {
            var value = await _vigenciaAppService.GetInstance();
            FormMarcarEntrada form = new FormMarcarEntrada(value.Item != null ? value.Item.ValorHora : 2, _registroAppService);
            form.ShowDialog();
        }

        private async void MenuGeral_Load(object sender, EventArgs e)
        {
            var movimentacoes = await _registroAppService.GetAllMovimentacoes();
            if (movimentacoes != null)
            {
                DataGridMenuMovimentaçoes.DataSource = movimentacoes.Dados;
                TotalValueLabel.Text = movimentacoes.Dados.Sum(sum => Convert.ToDecimal(sum.ValorTotal)).ToString();
            }
            else
            {
                DataGridMenuMovimentaçoes.DataSource = null;
            }

        }

        private async void BtnMarcarSaida_Click(object sender, EventArgs e)
        {
            var entradas = await _registroAppService.GetAllEntradas();

            FormMarcarSaida form = new FormMarcarSaida(entradas.Dados, _registroAppService);
            form.ShowDialog();
        }

        private async void ReloadGrid_Click(object sender, EventArgs e)
        {
            var movimentacoes = await _registroAppService.GetAllMovimentacoes();
            if (movimentacoes != null)
            {
                DataGridMenuMovimentaçoes.DataSource = movimentacoes.Dados;
                TotalValueLabel.Text = movimentacoes.Dados.Sum(sum => Convert.ToDecimal(sum.ValorTotal)).ToString();
            }
            else
            {
                DataGridMenuMovimentaçoes.DataSource = null;
            }
        }
    }
}
