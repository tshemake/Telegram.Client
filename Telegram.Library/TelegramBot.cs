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
            CancellationToken cancellationToken
        ) =>
            await SendRequestAsync<bool>(new SetWebhookRequest(url), cancellationToken);

        public async Task<WebhookInfo> GetWebhookInfoAsync(CancellationToken cancellationToken)
            => await SendRequestAsync<WebhookInfo>(new GetWebhookInfoRequest(), cancellationToken);

        public async Task<User> GetMeAsync(CancellationToken cancellationToken) => await SendRequestAsync<User>(new GetMeRequest(), cancellationToken);

        public async Task<Message> SendTextMessageAsync(
            ChatId chatId,
            string text,
            CancellationToken cancellationToken
        ) =>
            await SendRequestAsync<Message>(new SendMessageRequest(chatId, text), cancellationToken);
    }
}
