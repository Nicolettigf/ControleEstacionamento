namespace Shared
{
    /// <summary>
    /// Classe Responsevel por trazer uma resposta em texto um boleano dizendo se foi efetiva e uma lista de Classes
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DataResponse<T> : Response
    {
        public DataResponse(string message, bool hasSuccess, List<T> dados) : base(message, hasSuccess)
        {
            this.Dados = dados;
        }
        public List<T> Dados { get; private set; }
    }
}
