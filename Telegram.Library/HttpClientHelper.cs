using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;

namespace Telegram.Library
{
    internal abstract class HttpClientHelper
    {
        private readonly HttpClientHandler _httpClientHander;

        protected HttpClientHelper()
        {
        }

        protected HttpClientHelper(IWebProxy webProxy)
        {
            _httpClientHander = new HttpClientHandler
            {
                Proxy = webProxy,
                UseProxy = true
            };
        }

        public virtual HttpClient CreateHttpClient()
        {
            if (_httpClientHander != null)
            {
                return new HttpClient(_httpClientHander);
            }
            return new HttpClient();
        }
    }
}
