namespace ControleEstacionamento.Domain.Entidades
{
    public class VigenciaPreco : EntidadeBase
    {
        public DateTime InicioVigencia { get; set; }

        public DateTime FimVigencia { get; set; }

        public decimal ValorHora { get; set; }

        public VigenciaPreco ReturnDefault()
        {
            Id = 1;
            InicioVigencia = new DateTime(2023, 08, 24, 0, 0, 0);
            FimVigencia = new DateTime(2023, 11, 29, 0, 0, 0);
            ValorHora = Convert.ToDecimal("3,42");
            return this;
        }

        public void UpdateVigenceItens(VigenciaPreco vig)
        {
            InicioVigencia = vig.InicioVigencia;
            FimVigencia = vig.FimVigencia;
            ValorHora = vig.ValorHora;

        }
    }
}
