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
        Task<bool> SetWebhookAsync(string url,
                                   Action<bool> callback = null,
                                   Action<string, Exception> errorCallback = null,
                                   CancellationToken cancellationToken = default(CancellationToken));
        Task<WebhookInfo> GetWebhookInfoAsync(Action<WebhookInfo> callback = null,
                                              Action<string, Exception> errorCallback = null,
                                              CancellationToken cancellationToken = default(CancellationToken));
        Task<User> GetMeAsync(Action<User> callback = null,
                              Action<string, Exception> errorCallback = null,
                              CancellationToken cancellationToken = default(CancellationToken));
        Task<Message> SendTextMessageAsync(
            ChatId chatId,
            string text,
            Action<Message> callback = null,
            Action<string, Exception> errorCallback = null,
            CancellationToken cancellationToken = default(CancellationToken));
        Task<Message> SendTextMessageAsync(
            string token,
            ChatId chatId,
            string text,
            Action<Message> callback = null,
            Action<string, Exception> errorCallback = null,
            CancellationToken cancellationToken = default(CancellationToken));
        Task<bool> SendChatActionAsync(
            ChatId chatId,
            ChatAction chatAction,
            Action<bool> callback = null,
            Action<string, Exception> errorCallback = null,
            CancellationToken cancellationToken = default(CancellationToken));
        Task<bool> SendChatActionAsync(
            string token,
            ChatId chatId,
            ChatAction chatAction,
            Action<bool> callback = null,
            Action<string, Exception> errorCallback = null,
            CancellationToken cancellationToken = default(CancellationToken));
    }
}
