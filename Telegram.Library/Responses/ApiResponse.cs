using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.Library.Types;

namespace Telegram.Library.Responses
{
    internal class ApiResponse<TResult>
    {
        [JsonProperty(Required = Required.Always)]
        public bool Ok { get; set; }

        /// <summary>
        /// Gets the result object.
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public TResult Result { get; set; }

        /// <summary>
        /// Gets the error message.
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Gets the error code.
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int ErrorCode { get; set; }

        /// <summary>
        /// Contains information about why a request was unsuccessful.
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ResponseParameters Parameters { get; set; }
    }
}
