using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;

namespace Telegram.Library.Types
{
    /// <summary>
    /// Этот объект представляет входящее сообщение на webhook.
    /// Это может быть обновление.
    /// <see href="https://core.telegram.org/bots/api#update"/>
    /// </summary>
    /// <remarks>
    /// В любом данном обновлении может присутствовать только один из необязательных параметров.
    /// </remarks>
    public class Update
    {
        [Key]
        [JsonIgnore]
        public long Id { get; set; }

        /// <summary>
        /// Уникальный идентификатор сообщения.
        /// Идентификаторы начинаются с определенного положительного числа и последовательно увеличиваются.
        /// </summary>
        /// <remarks>
        /// Игнорировать повторяющиеся обновления или восстанавливать правильную последовательность, если была ошибка.
        /// </remarks>
        [Required]
        [JsonProperty("update_id", Required = Required.Always)]
        public long UniqueUpdateId { get; set; }

        /// <summary>
        /// Необязательный. Новое входящее сообщение любого типа - текст, фотография, стикер и т.д.
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Message Message { get; set; }

        /// <summary>
        /// Необязательный. Новая версия сообщения, которое известно боту и отредактировано
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Message EditedMessage { get; set; }

        /// <summary>
        /// Необязательный. Новый входящий встроенный запрос
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InlineQuery InlineQuery { get; set; }

        /// <summary>
        /// Необязательный. Результат встроенного запроса, который был выбран пользователем и отправлен его партнеру по чату
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ChosenInlineResult ChosenInlineResult { get; set; }

        /// <summary>
        /// Необязательный.Новый входящий запрос обратного вызова
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CallbackQuery CallbackQuery { get; set; }

        /// <summary>
        /// Необязательный. Новая входящая запись на канале любого типа - текст, фото, стикер и т.д.
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Message ChannelPost { get; set; }

        /// <summary>
        /// Необязательный. Новая версия сообщения на «channel», известная боту и отредактированная
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Message EditedChannelPost { get; set; }

        /// <summary>
        /// Необязательный. Новый запрос на входящую доставку. Только для счетов с гибкой ценой
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ShippingQuery ShippingQuery { get; set; }

        /// <summary>
        /// Необязательный. Новый входящий запрос предварительной проверки.
        /// Содержит полную информацию об оформлении заказа
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PreCheckoutQuery PreCheckoutQuery { get; set; }

        public UpdateType Type
        {
            get
            {
                if (Message != null) return UpdateType.Message;
                if (InlineQuery != null) return UpdateType.InlineQuery;
                if (ChosenInlineResult != null) return UpdateType.ChosenInlineResult;
                if (CallbackQuery != null) return UpdateType.CallbackQuery;
                if (EditedMessage != null) return UpdateType.EditedMessage;
                if (ChannelPost != null) return UpdateType.ChannelPost;
                if (EditedChannelPost != null) return UpdateType.EditedChannelPost;
                if (ShippingQuery != null) return UpdateType.ShippingQuery;
                if (PreCheckoutQuery != null) return UpdateType.PreCheckoutQuery;

                return UpdateType.Unknown;
            }
        }
    }
}
