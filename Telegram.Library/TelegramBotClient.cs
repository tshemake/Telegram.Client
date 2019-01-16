using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Telegram.Library.Exceptions;
using Telegram.Library.Types;
using Telegram.Library.Requests;
using Telegram.Library.Responses;

namespace Telegram.Library
{
    public class TelegramBotClient
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

        public async Task<User> GetMeAsync(CancellationToken cancellationToken) => await SendRequestAsync<User>(new GetMeRequest(), cancellationToken);

        public async Task<TResponse> SendRequestAsync<TResponse>(IRequest request, CancellationToken cancellationToken, bool throwOnError = true)
        {
            string url = string.Concat(_bot.BaseRequestUrl, request.MethodName);
            if (!UriValidator.IsValidUri(url)) throw new UriFormatException(url);

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
    }
}
