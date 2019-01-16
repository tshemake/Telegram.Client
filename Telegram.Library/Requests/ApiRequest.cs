using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Telegram.Library.Exceptions;
using Telegram.Library.Responses;

namespace Telegram.Library.Requests
{
    internal class ApiRequest<TResponseType>
    {
        public static readonly JsonSerializer JsonObjectTypeSerializer = JsonSerializer.Create();

        private readonly IRequest _request;
        private readonly string _requestUrl;

        public int ErrorCode { get; private set; }
        public string ErrorMessage { get; private set; }

        public TResponseType Result { get; private set; }

        public ApiRequest(IRequest request, string url)
        {
            _request = request;
            _requestUrl = url;
        }

        public HttpRequestMessage OnSend()
        {
            return new HttpRequestMessage(_request.Method, _requestUrl)
            {
                Content = _request.ToHttpContent()
            };
        }

        public async Task OnResponseAsync(HttpResponseMessage response)
        {
            var apiResponse = await ReadContentAsJsonAsync<ApiResponse<TResponseType>>(response)
                    ?? new ApiResponse<TResponseType>
                    {
                        Ok = false,
                        Description = "Пустой ответ"
                    };
            if (!apiResponse.Ok)
                OnError(apiResponse.ErrorCode, apiResponse.Description);

            Result = apiResponse.Result;
        }

        private static async Task<T> ReadContentAsJsonAsync<T>(HttpResponseMessage message, bool rewindContentStream = false)
        {
            using (var stream = await message.Content
                .ReadAsStreamAsync()
                .ConfigureAwait(continueOnCapturedContext: false))
            {
                var streamPosition = stream.Position;
                try
                {
                    return FromJson<T>(stream);
                }
                finally
                {
                    if (stream.CanSeek && streamPosition != stream.Position && rewindContentStream)
                    {
                        stream.Seek(streamPosition, SeekOrigin.Begin);
                    }
                }
            }
        }

        private static T FromJson<T>(Stream stream)
        {
            using (var streamReader = new StreamReader(stream))
            using (var jsonReader = new JsonTextReader(streamReader))
            {
                return JsonObjectTypeSerializer.Deserialize<T>(jsonReader);
            }
        }

        public void OnError(int errorCode, string errorMessage)
        {
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
        }

        public void ThrowIfHasError()
        {
            if (ErrorCode != 0)
            {
                HandleError();
            }
        }

        private void HandleError()
        {
            Debug.WriteLine($"Произошла ошибка {ErrorCode} - {ErrorMessage}");
            throw new ApiRequestException(ErrorMessage, ErrorCode);
        }
    }
}
