using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Library.Requests;

namespace Telegram.Library
{
    public partial class TelegramBotClient : ITelegramBotClient
    {
        private readonly Bot _bot;
        private readonly ApiSender _sender;

        public TelegramBotClient(string token, HttpClient httpClient = null)
        {
            _bot = new Bot();
            _bot.SetToken(token);

            _sender = new ApiSender(httpClient);
        }

        public TelegramBotClient(string token, IWebProxy webProxy)
        {
            _bot = new Bot();
            _bot.SetToken(token);

            _sender = new ApiSender(webProxy);
        }

        private async Task<TResponse> SendRequestAsync<TResponse>(IRequest request, CancellationToken cancellationToken = new CancellationToken(), bool throwOnError = true)
        {
            string url = BuildUrl(_bot.BaseRequestUrl, request.MethodName);;
            var apiRequst = new ApiRequest<TResponse>(request, url);
            try
            {
                await _sender.SendAsync(apiRequst, cancellationToken);
            }
            catch (Exception)
            {
                if (throwOnError) throw;
            }
            if (throwOnError) apiRequst.ThrowIfHasError();

            return apiRequst.Result;
        }

        private string BuildUrl(string BaseRequestUrl, string methodName)
        {
            string url = string.Concat(_bot.BaseRequestUrl, methodName);
            if (!UriValidator.IsValidUri(url)) throw new UriFormatException(url);

            return url;
        }
    }
}
