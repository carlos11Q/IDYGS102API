using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Modelos
{
    public class Response<T>
    {
        public Response()
        { }
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Result { get; set; }
        public Response(T data, string message) //crear cualquiera objeto generico
        {
            Success = true;
            Message = message;
            Result = data;
        }
    }
}
