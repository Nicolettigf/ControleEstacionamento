namespace Shared
{
    /// <summary>
    /// Classe Responsevel por trazer uma resposta em texto um boleano dizendo se foi efetiva e uma Classe preenchida
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SingleResponse<T> : Response
    {

        public SingleResponse(string message, bool hasSuccess, T item) : base(message, hasSuccess)
        {
            this.Item = item;
        }
        public T Item { get; private set; }
    }
}