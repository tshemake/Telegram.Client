using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace Telegram.Library.Requests
{
    public abstract class RequestBase : IRequest
    {
        [JsonIgnore]
        public HttpMethod Method { get; }

        [JsonIgnore]
        public string MethodName { get; protected set; }

        protected RequestBase(string methodName, HttpMethod method)
        {
            MethodName = methodName;
            Method = method;
        }

        public HttpContent ToHttpContent()
        {
            return Serialize();
        }

        public abstract HttpContent Serialize();
    }
}
