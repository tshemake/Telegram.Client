﻿using System;
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
            CancellationToken cancellationToken = default(CancellationToken)
        ) =>
            await SendRequestAsync<bool>(new SetWebhookRequest(url), cancellationToken);

        public async Task<WebhookInfo> GetWebhookInfoAsync(CancellationToken cancellationToken = default(CancellationToken))
            => await SendRequestAsync<WebhookInfo>(new GetWebhookInfoRequest(), cancellationToken);

        public async Task<User> GetMeAsync(CancellationToken cancellationToken) 
            => await SendRequestAsync<User>(new GetMeRequest(), cancellationToken);

        public async Task<Message> SendTextMessageAsync(
            ChatId chatId,
            string text,
            CancellationToken cancellationToken = default(CancellationToken)
        ) =>
            await SendRequestAsync<Message>(new SendMessageRequest(chatId, text), cancellationToken);

        public async Task<Message> SendTextMessageAsync(
            string token,
            ChatId chatId,
            string text,
            CancellationToken cancellationToken = default(CancellationToken)
        ) =>
            await SendRequestAsync<Message>(token, new SendMessageRequest(chatId, text), cancellationToken);

        public async Task<bool> SendChatActionAsync(
            ChatId chatId,
            ChatAction chatAction,
            CancellationToken cancellationToken = default(CancellationToken)
        ) =>
            await SendRequestAsync<bool>(new SendChatActionRequest(chatId, chatAction), cancellationToken);

        public async Task<bool> SendChatActionAsync(
            string token,
            ChatId chatId,
            ChatAction chatAction,
            CancellationToken cancellationToken = default(CancellationToken)
        ) =>
            await SendRequestAsync<bool>(token, new SendChatActionRequest(chatId, chatAction), cancellationToken);
    }
}
