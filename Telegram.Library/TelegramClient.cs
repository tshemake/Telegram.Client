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

        public TelegramBotClient(HttpClient httpClient = null)
        {
            _bot = new Bot();
            _sender = new ApiSender(httpClient);
        }

        public TelegramBotClient(IWebProxy webProxy)
        {
            _bot = new Bot();
            _sender = new ApiSender(webProxy);
        }

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

        public void SetToken(string token)
        {
            _bot.SetToken(token);
        }

        private async Task<TResponse> SendRequestAsync<TResponse>(IRequest request, CancellationToken cancellationToken = new CancellationToken(), bool throwOnError = true)
        {
            string url = BuildUrl(_bot.BaseRequestUrl, request.MethodName);
            var apiRequst = new ApiRequest<TResponse>(request, url);
            try
            {
                await _sender.SendAsync(apiRequst, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
                if (throwOnError) throw;
            }
            if (throwOnError) apiRequst.ThrowIfHasError();

            return apiRequst.Result;
        }

        private async Task<TResponse> SendRequestAsync<TResponse>(string token, IRequest request, CancellationToken cancellationToken = new CancellationToken(), bool throwOnError = true)
        {
            string baseRequestUrl = Bot.TryGetBaseRequestUrl(token);
            if (string.IsNullOrEmpty(baseRequestUrl))
            {
                throw new ArgumentException(
                    "Ошибка формата. Валидный токен выглядит так \"1234567:4TT8bAc8GHUspu3ERYn-KGcvsvGB9u_n4ddy\".",
                    nameof(token));
            }

            string url = BuildUrl(baseRequestUrl, request.MethodName);
            var apiRequst = new ApiRequest<TResponse>(request, url);
            try
            {
                await _sender.SendAsync(apiRequst, cancellationToken).ConfigureAwait(false);
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
