using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Library.Requests;
using Telegram.Library.Types;

namespace Telegram.Library
{
    public interface ITelegramBotClient
    {
        Task<bool> SetWebhookAsync(string url, CancellationToken cancellationToken);
        Task<WebhookInfo> GetWebhookInfoAsync(CancellationToken cancellationToken);
        Task<User> GetMeAsync(CancellationToken cancellationToken);
        Task<Message> SendTextMessageAsync(
            ChatId chatId,
            string text,
            CancellationToken cancellationToken);
        Task<bool> SendChatActionAsync(
            ChatId chatId,
            ChatAction chatAction,
            CancellationToken cancellationToken = default(CancellationToken));
    }
}
