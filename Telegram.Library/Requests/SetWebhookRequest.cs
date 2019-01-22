using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Telegram.Library.Types;

namespace Telegram.Library.Requests
{
    public class SetWebhookRequest : FileRequestBase
    {
        [JsonProperty(Required = Required.Always)]
        public string Url { get; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int MaxConnections { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<UpdateType> AllowedUpdates { get; set; }

        public SetWebhookRequest(string url)
            : base("setWebhook")
        {
            Url = url;
        }
    }
}
