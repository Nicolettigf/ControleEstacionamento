using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ResponseFactory
    {
        #region Singleton
        private static ResponseFactory _factory;

        public static ResponseFactory CreateInstance()
        {
            if (_factory == null)
            {
                _factory = new ResponseFactory();
            }
            return _factory;
        }

        private ResponseFactory() { }
        #endregion Singleton

        public  Response CreateSuccessResponse()
        {
            return new Response("Operação realizada com sucesso.", true);
        }
        public  SingleResponse<T> CreateSingleSuccessResponse<T>(T item)
        {
            return new SingleResponse<T>("Dado coletado de " + typeof(T).Name + " com sucesso", true, item);
        }
        public DataResponse<T> CreateDataSuccessResponse<T>(List<T> item)
        {
            return new DataResponse<T>("Dados coletados de " + typeof(T).Name + " com sucesso", true, item);
        }
        public Response CreateFailedResponse(string ex)
        {
            return new Response(ex, false);
        }

        public SingleResponse<T> CreateSingleFailedResponse<T>(string ex,T item)
        {
            return new SingleResponse<T>(ex, false, item);
        }

    }
}
