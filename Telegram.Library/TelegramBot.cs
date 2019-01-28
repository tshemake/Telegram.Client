using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Library.Types;
using Telegram.Library.Requests;

namespace Telegram.Library
{
    public partial class TelegramBotClient : ITelegramBotClient
    {
        public async Task<bool> SetWebhookAsync(
            string url,
            Action<bool> callback = null,
            Action<string, Exception> errorCallback = null,
            CancellationToken cancellationToken = default(CancellationToken)
        ) =>
            await SendRequestAsync<bool>(new SetWebhookRequest(url), callback, errorCallback, cancellationToken);

        public async Task<WebhookInfo> GetWebhookInfoAsync(Action<WebhookInfo> callback = null, Action<string, Exception> errorCallback = null, CancellationToken cancellationToken = default(CancellationToken))
            => await SendRequestAsync<WebhookInfo>(new GetWebhookInfoRequest(), callback, errorCallback, cancellationToken);

        public async Task<User> GetMeAsync(Action<User> callback = null, Action<string, Exception> errorCallback = null, CancellationToken cancellationToken = default(CancellationToken)) 
            => await SendRequestAsync<User>(new GetMeRequest(), callback, errorCallback, cancellationToken);

        public async Task<Message> SendTextMessageAsync(
            ChatId chatId,
            string text,
            Action<Message> callback = null,
            Action<string, Exception> errorCallback = null,
            CancellationToken cancellationToken = default(CancellationToken)
        ) =>
            await SendRequestAsync<Message>(new SendMessageRequest(chatId, text), callback, errorCallback, cancellationToken);

        public async Task<Message> SendTextMessageAsync(
            string token,
            ChatId chatId,
            string text,
            Action<Message> callback = null, 
            Action<string, Exception> errorCallback = null,
            CancellationToken cancellationToken = default(CancellationToken)
        ) =>
            await SendRequestAsync<Message>(token, new SendMessageRequest(chatId, text), callback, errorCallback, cancellationToken);

        public async Task<bool> SendChatActionAsync(
            ChatId chatId,
            ChatAction chatAction,
            Action<bool> callback = null,
            Action<string, Exception> errorCallback = null,
            CancellationToken cancellationToken = default(CancellationToken)
        ) =>
            await SendRequestAsync<bool>(new SendChatActionRequest(chatId, chatAction), callback, errorCallback, cancellationToken);

        public async Task<bool> SendChatActionAsync(
            string token,
            ChatId chatId,
            ChatAction chatAction,
            Action<bool> callback = null,
            Action<string, Exception> errorCallback = null,
            CancellationToken cancellationToken = default(CancellationToken)
        ) =>
            await SendRequestAsync<bool>(token, new SendChatActionRequest(chatId, chatAction), callback, errorCallback, cancellationToken);
    }
}
