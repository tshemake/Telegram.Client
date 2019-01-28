﻿using System;
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

        public ApiSender(IWebProxy webProxy)
            : this(HttpClientHelperFactory.Instance.CreateHttpClientHelper(webProxy).CreateHttpClient())
        {
        }

        public ApiSender(HttpClient httpClient = null)
        {
            _httpClient = httpClient ?? HttpClientHelperFactory.Instance.CreateHttpClientHelper().CreateHttpClient();
        }

        public async Task SendAsync<TResponse>(ApiRequest<TResponse> request, Action<TResponse> callback = null, Action<string, Exception> errorCallback = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                var httpRequest = request.OnSend();
                var httpResponse = await PollyHttpClient.PostAsync(_httpClient, httpRequest, cancellationToken)
                                       .ConfigureAwait(continueOnCapturedContext: false);

                if (!httpResponse.StatusCode.IsSuccessfulRequest())
                {
                    var error = await httpResponse.Content.ReadAsStringAsync();
                    throw new ApiResponseException(error, httpResponse.StatusCode);
                }

                cancellationToken.ThrowIfCancellationRequested();

                await ProcessResponseAsync(request, httpResponse).ConfigureAwait(false);

                callback?.Invoke(request.Result);
            }
            catch (TaskCanceledException ex)
            {
                errorCallback?.Invoke("Request was canceled", ex);
                if (cancellationToken.IsCancellationRequested)
                    throw;
                throw new ApiRequestException("Превышение таймаута", 408, ex);
            }
            catch (ApiResponseException ex)
            {
                errorCallback?.Invoke("Request failed", ex);
                throw;
            }
        }

        private async Task ProcessResponseAsync<TResponse>(ApiRequest<TResponse> request, HttpResponseMessage response)
        {
            await request.OnResponseAsync(response).ConfigureAwait(false);
        }
    }
}
