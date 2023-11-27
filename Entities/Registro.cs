namespace ControleEstacionamento.Domain.Entidades
{
    public class Registro : EntidadeBase
    {
        public Registro()
        {
        }

        public Registro(DateTime horarioEntrada, decimal valorHora, Carro carro)
        {
            HorarioEntrada = horarioEntrada;
            ValorHora = valorHora;
            Carro = carro;
        }

        public DateTime HorarioEntrada { get; set; }

        public DateTime? HorarioSaida { get; set; }

        public decimal ValorHora { get; set; }

        public decimal? ValorTotal { get; set; }

        public Carro Carro { get; set; }

        public int CarroId { get; set; }

        public decimal CalcularValorTotal(string? entrada, DateTime horariosaida, string? valorHora)
        {
            // Regra do valor
            DateTime HorarioEntrada = Convert.ToDateTime(entrada);
            var diferenca = horariosaida - HorarioEntrada;
            if (Math.Round(diferenca.TotalHours, MidpointRounding.ToZero) == 0 && Math.Round(diferenca.TotalMinutes, MidpointRounding.ToZero) <= 30)
            {
                return Convert.ToDecimal(valorHora) / 2;
            }
            else
            {
                if ((Convert.ToDecimal(diferenca.TotalMinutes) - (Convert.ToDecimal(Math.Round(diferenca.TotalHours, MidpointRounding.ToZero)) * 60)) <= 10)
                {
                    return Convert.ToDecimal(valorHora) * Convert.ToDecimal(Math.Round(diferenca.TotalHours, MidpointRounding.ToZero));
                }
                else
                {
                    return Convert.ToDecimal(valorHora) * (Convert.ToDecimal(Math.Round(diferenca.TotalHours, MidpointRounding.ToZero)) + 1);
                }
            }
        }

        public void MarcarHorarioSaida(DateTime saida, decimal valorTotal)
        {
            HorarioSaida = saida;
            ValorTotal = valorTotal;
        }
    }
}
