using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Telegram.Library.Requests
{
    public class ParameterlessRequest : RequestBase
    {
        public ParameterlessRequest(string methodName)
            : this(methodName, HttpMethod.Post)
        {
        }

        public ParameterlessRequest(string methodName, HttpMethod method)
            : base(methodName, method)
        {
        }

        public override HttpContent Serialize() => null;
    }
}
