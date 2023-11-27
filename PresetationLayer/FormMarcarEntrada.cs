using BLL.Interfaces;
using ControleEstacionamento.Application.Services;
using ControleEstacionamento.Domain.Entidades;

namespace PresetationLayer
{
    public partial class FormMarcarEntrada : Form
    {
        decimal valor;
        private readonly IRegistroAppService _registroAppService;
        public FormMarcarEntrada(decimal valorHora, IRegistroAppService registroAppService)
        {
            _registroAppService = registroAppService;
            valor = valorHora;
            InitializeComponent();
        }

        private void MarcarChegadaButton_Click(object sender, EventArgs e)
        {
            _registroAppService.Create(new Registro(dateTimePicker1.Value, valor, new Carro() { Placa = !String.IsNullOrEmpty(CmbplacasSalvas.Text) ? CmbplacasSalvas.Text : txtBoxNewPlaca.Text, }));
        }

        private async void FormMarcarEntrada_Load(object sender, EventArgs e)
        {
            var list = await _registroAppService.GetListCars();
            CmbplacasSalvas.Items.AddRange(list.Dados.ToArray());
        }
    }
}
