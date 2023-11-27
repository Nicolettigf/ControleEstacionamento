using BLL.Interfaces;
using ControleEstacionamento.Domain.Entidades;

namespace PresetationLayer
{
    public partial class FormAlterarVigencia : Form
    {
        private readonly IVigenciaAppService _vigenciaAppService;
        bool HasVigence = true;
        public FormAlterarVigencia(IVigenciaAppService vigenciaAppService)
        {
            _vigenciaAppService = vigenciaAppService;
            InitializeComponent();
        }
        private async void FormAlterarVigencia_Load(object sender, EventArgs e)
        {
            var vigence = await _vigenciaAppService.GetInstance();
            if (vigence != null)
            {
                InicioVigenciaDate.Value = vigence.Item.InicioVigencia;
                FimVigenciaDate.Value = vigence.Item.FimVigencia;
                TxtBoxVigenciaValue.Text = vigence.Item.ValorHora.ToString();
            }
            else { HasVigence = false; }
        }

        private async void CHangeCopetenceButton_Click(object sender, EventArgs e)
        {
            VigenciaPreco vigencia = new()
            {
                InicioVigencia = Convert.ToDateTime(InicioVigenciaDate.Text),
                FimVigencia = Convert.ToDateTime(FimVigenciaDate.Text),
                ValorHora = Convert.ToDecimal(TxtBoxVigenciaValue.Text)
            };
            var response = HasVigence ? await _vigenciaAppService.UpdateInstance(vigencia) : await _vigenciaAppService.Create(vigencia);
            MessageBox.Show(response.Message);
        }

        private void CHangeCopetence_Validating(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

    }
}
