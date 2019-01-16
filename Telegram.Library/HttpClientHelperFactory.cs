using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Telegram.Library
{
    internal class HttpClientHelperFactory
    {
        public static HttpClientHelperFactory Instance { get; protected set; }

        static HttpClientHelperFactory()
        {
            Instance = new HttpClientHelperFactory();
        }

        protected HttpClientHelperFactory()
        {
        }

        public virtual HttpClientHelper CreateHttpClientHelper()
        {
            return new HttpClientHelperImpl();
        }

        public virtual HttpClientHelper CreateHttpClientHelper(IWebProxy webProxy)
        {
            return new HttpClientHelperImpl(webProxy);
        }

        private class HttpClientHelperImpl : HttpClientHelper
        {
            public HttpClientHelperImpl()
            {
            }

            public HttpClientHelperImpl(IWebProxy webProxy)
                : base(webProxy)
            {
            }
        }
    }
}
