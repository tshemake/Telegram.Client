using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Telegram.Library.Types
{
    /// <summary>
    /// The type of an <see cref="Update"/>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter), true)]
    public enum UpdateType
    {
        /// <summary>
        /// Update Type is unknown
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// The <see cref="Update"/> contains a <see cref="Models.Message"/>.
        /// </summary>
        Message,

        /// <summary>
        /// The <see cref="Update"/> contains an <see cref="Models.InlineQuery"/>.
        /// </summary>
        [EnumMember(Value = "inline_query")]
        InlineQuery,

        /// <summary>
        /// The <see cref="Update"/> contains a <see cref="Models.ChosenInlineResult"/>.
        /// </summary>
        [EnumMember(Value = "chosen_inline_result")]
        ChosenInlineResult,

        /// <summary>
        /// The <see cref="Update"/> contains a <see cref="Models.CallbackQuery"/>
        /// </summary>
        [EnumMember(Value = "callback_query")]
        CallbackQuery,

        /// <summary>
        /// The <see cref="Update"/> contains an edited <see cref="Models.Message"/>
        /// </summary>
        [EnumMember(Value = "edited_message")]
        EditedMessage,

        /// <summary>
        /// The <see cref="Update"/> contains a channel post <see cref="Models.Message"/>
        /// </summary>
        [EnumMember(Value = "channel_post")]
        ChannelPost,

        /// <summary>
        /// The <see cref="Update"/> contains an edited channel post <see cref="Models.Message"/>
        /// </summary>
        [EnumMember(Value = "edited_channel_post")]
        EditedChannelPost,

        /// <summary>
        /// The <see cref="Update"/> contains an <see cref="Models.ShippingQuery"/>
        /// </summary>
        [EnumMember(Value = "shipping_query")]
        ShippingQuery,

        /// <summary>
        /// The <see cref="Update"/> contains an <see cref="Models.PreCheckoutQuery"/>
        /// </summary>
        [EnumMember(Value = "pre_checkout_query")]
        PreCheckoutQuery,
    }

    /// <summary>
    /// Текущий статус webhook.
    /// </summary>
    public class WebhookInfo
    {
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Webhook URL
        /// </summary>
        /// <remarks>
        /// Может быть пустым, если веб-крючок не настроен
        /// </remarks>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public string Url { get; set; }

        /// <summary>
        /// True, если для проверки сертификатов webhook был предоставлен специальный сертификат
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public bool HasCustomCertificate { get; set; }

        /// <summary>
        /// Количество обновлений, ожидающих доставки
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public int PendingUpdateCount { get; set; }

        /// <summary>
        /// Необязательный. <see href="https://en.wikipedia.org/wiki/Unix_time">Unix временя</see> последней ошибки,
        /// которая произошла при попытке доставить обновление через webhook
        /// </summary>
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime LastErrorDate { get; set; }

        /// <summary>
        /// Необязательный. Сообщение об ошибке в удобочитаемом формате для последней ошибки,
        /// которая произошла при попытке доставить обновление через webhook
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LastErrorMessage { get; set; }

        /// <summary>
        /// Необязательный. Максимально допустимое количество одновременных HTTPS-подключений к webhook 
        /// для доставки обновлений
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int MaxConnections { get; set; }

        /// <summary>
        /// Необязательный. Список типов обновлений, на которые подписан бот.
        /// </summary>
        /// <remarks>
        /// По умолчанию для всех типов обновлений
        /// </remarks>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<UpdateType> AllowedUpdates { get; set; }
    }
}
