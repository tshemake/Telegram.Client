using System;
using System.Collections.Generic;
using System.Text;

namespace Telegram.Library
{
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Polly;
    using Polly.Retry;

    public class PollyHttpClient
    {
        private static readonly RetryPolicy<HttpResponseMessage> _retryPolicy = Policy.Handle<HttpRequestException>()
            .Or<TaskCanceledException>()
            .OrResult<HttpResponseMessage>(r => r.StatusCode.IsSuccessfulRequest())
            .WaitAndRetryAsync(3, retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)),
                (result, timeSpan, retryCount, context) =>
                {
                    var isException = result.Exception != null;
                });

        public static async Task<HttpResponseMessage> PostAsync(HttpClient httpClient, HttpRequestMessage request, CancellationToken cancellationToken)
            => await _retryPolicy.ExecuteAsync(async () =>
            {
                return await httpClient.SendAsync(request, cancellationToken);
            });
    }
}
