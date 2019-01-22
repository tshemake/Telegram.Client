using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.Library.Requests
{
    public class RequestWithParameters : RequestBase
    {
        public static readonly JsonSerializerSettings ObjectSerializationSettings = new JsonSerializerSettings
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new SnakeCaseNamingStrategy()
            }
        };

        public RequestWithParameters(string methodName)
            : this(methodName, HttpMethod.Post)
        {
        }

        public RequestWithParameters(string methodName, HttpMethod method)
            : base(methodName, method)
        {
        }

        public override HttpContent Serialize()
        {
            string payload = JsonConvert.SerializeObject(this, ObjectSerializationSettings);
            return new StringContent(payload, Encoding.UTF8, "application/json");
        }
    }
}
