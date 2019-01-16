using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Library.Exceptions;
using Telegram.Library.Requests;

namespace Telegram.Library
{
    internal class ApiSender
    {
        private readonly HttpClient _httpClient;

        public ApiSender(HttpClient httpClient = null)
        {
            _httpClient = httpClient ?? new HttpClient();
        }

        public ApiSender(IWebProxy webProxy, HttpClient httpClient = null)
        {
           var httpClientHander = new HttpClientHandler
            {
                Proxy = webProxy,
                UseProxy = true
            };
            _httpClient = httpClient ?? new HttpClient(httpClientHander);
        }

        public async Task SendAsync<TResponse>(ApiRequest<TResponse> request, CancellationToken cancellationToken)
        {
            var httpRequest = request.OnSend();

            HttpResponseMessage httpResponse;
            try
            {
                httpResponse = await _httpClient.SendAsync(httpRequest, cancellationToken)
                    .ConfigureAwait(continueOnCapturedContext: false);

                if (!httpResponse.StatusCode.IsSuccessfulRequest())
                {
                    throw new ApiResponseException("Ошибка ответа", httpResponse.StatusCode);
                }
            }
            catch (TaskCanceledException ex)
            {
                if (cancellationToken.IsCancellationRequested)
                    throw;

                throw new ApiRequestException("Превышение таймаута", 408, ex);
            };

            await request.OnResponseAsync(httpResponse).ConfigureAwait(false);
        }
    }
}
