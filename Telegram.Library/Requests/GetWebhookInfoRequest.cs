using System;
using System.Collections.Generic;
using System.Text;

namespace Telegram.Library.Requests
{
    class GetWebhookInfoRequest : ParameterlessRequest
    {
        public GetWebhookInfoRequest()
            : base("getWebhookInfo")
        { }
    }
}
