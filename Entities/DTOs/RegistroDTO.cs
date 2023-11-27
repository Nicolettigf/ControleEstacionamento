namespace ControleEstacionamento.Application.DTOs
{
    public class RegistroDTO
    {
        public string PlacaCarro { get; set; }
        public string? ValorHora { get; set; }

        public string? ValorTotal { get; set; }

        public string? HorarioEntrada { get; set; }

        public string? HorarioSaida { get; set; }

        public string? Duracao { get; set; }
        public string? TempoCobrado { get; set; }


    }
}
