using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.Library.Types;

namespace Telegram.Library.Requests
{
    /// <summary>
    /// Используйтся для отправки текстовых сообщений.
    /// В случае успеха отправленное сообщение возвращается.
    /// </summary>
    public class SendMessageRequest : RequestWithParameters
    {
        public SendMessageRequest(ChatId chatId, string text)
            : base("sendMessage", HttpMethod.Post)
        {
            ChatId = chatId;
            Text = text;
        }

        /// <summary>
        /// Уникальный идентификатор целевого чата или имя пользователя целевого канала (в формате @channelusername)
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public ChatId ChatId { get; }

        /// <summary>
        /// Текст сообщения для отправки
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public string Text { get; }

        /// <summary>
        /// Необязательный. Отправьте <see href="https://core.telegram.org/bots/api#markdown-style">Markdown</see> или <see href="https://core.telegram.org/bots/api#html-style">HTML</see>, если вы хотите 
        /// чтобы приложения Telegram отображали
        /// <see href="https://core.telegram.org/bots/api#formatting-options">жирный шрифт, курсив, текст фиксированной ширины или встроенные URL-адреса</see> в заголовке мультимедиа.
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ParseMode ParseMode { get; set; }

        /// <summary>
        /// Отключить предварительный просмотр ссылок в этом сообщении
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool DisableWebPagePreview { get; set; }

        /// <summary>
        /// Отправляет сообщение <see href="https://telegram.org/blog/channels-2-0#silent-messages">молча</see>. Пользователи получат уведомление без звука.
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool DisableNotification { get; set; }

        /// <summary>
        /// Если сообщение является ответом, идентификатор исходного сообщения
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int ReplyToMessageId { get; set; }

        /// <summary>
        /// Дополнительные параметры интерфейса.
        /// Сериализованный в JSON объект для <see cref="InlineKeyboardMarkup"/>, <see cref="ReplyKeyboardMarkup"/>, <see cref="ReplyKeyboardRemove"/> или <see cref="ForceReplyMarkup"/>
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IReplyMarkup ReplyMarkup { get; set; }
    }
}
