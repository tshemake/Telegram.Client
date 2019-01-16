using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Telegram.Library.Requests
{
    public interface IRequest
    {
        HttpMethod Method { get; }

        string MethodName { get; }

        HttpContent ToHttpContent();
    }
}
