using BLL.Interfaces;
using ControleEstacionamento.Application.DTOs;
using ControleEstacionamento.Domain.Entidades;

namespace PresetationLayer
{
    public partial class FormMarcarSaida : Form
    {
        private readonly IRegistroAppService _registroAppService;
        public FormMarcarSaida(List<RegistroDTO> dados, IRegistroAppService registroAppService)
        {
            _registroAppService = registroAppService;
            InitializeComponent();
            GridCarrosComEntrada.DataSource = dados;
        }

        private void FormMarcarSaida_Load(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var saida = DateTime.Now;
            if (e.RowIndex >= 0 && e.RowIndex < GridCarrosComEntrada.Rows.Count)
            {
                string valorHora = GridCarrosComEntrada.Rows[e.RowIndex].Cells["ValorHora"].Value.ToString();
                string entrada = GridCarrosComEntrada.Rows[e.RowIndex].Cells["HorarioEntrada"].Value.ToString();
                string placa = GridCarrosComEntrada.Rows[e.RowIndex].Cells["PlacaCarro"].Value.ToString();

                var valortotal = new Registro().CalcularValorTotal(entrada, saida, valorHora);

                var messege = MessageBox.Show($"Deseja marcar a saida do carro {placa} o valor ficara R${valortotal} no total","Tem certeza",MessageBoxButtons.YesNoCancel);

                if (messege == DialogResult.Yes)
                {
                    _registroAppService.UpdateRegistro(placa, saida, valortotal);
                }
            }
        }
    }
}
