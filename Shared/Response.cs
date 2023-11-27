namespace Shared
{
    /// <summary>
    /// Classe responsavel por retornar uma string de mensagem e um boleano se foi efetivada
    /// </summary>
    public class Response
    {
        public Response(string message, bool hasSuccess)
        {
            Message = message;
            HasSuccess = hasSuccess;
        }
        public string Message { get; private set; }
        public bool HasSuccess { get; private set; }
        
    }
}
