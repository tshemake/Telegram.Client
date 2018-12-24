using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Models
{
    /// <summary>
    /// The type of an <see cref="Update"/>
    /// </summary>
    public enum UpdateType
    {
        /// <summary>
        /// Update Type is unknown
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// The <see cref="Update"/> contains a <see cref="Types.Message"/>.
        /// </summary>
        Message,

        /// <summary>
        /// The <see cref="Update"/> contains an <see cref="Types.InlineQuery"/>.
        /// </summary>
        InlineQuery,

        /// <summary>
        /// The <see cref="Update"/> contains a <see cref="Types.ChosenInlineResult"/>.
        /// </summary>
        ChosenInlineResult,

        /// <summary>
        /// The <see cref="Update"/> contains a <see cref="Types.CallbackQuery"/>
        /// </summary>
        CallbackQuery,

        /// <summary>
        /// The <see cref="Update"/> contains an edited <see cref="Types.Message"/>
        /// </summary>
        EditedMessage,

        /// <summary>
        /// The <see cref="Update"/> contains a channel post <see cref="Types.Message"/>
        /// </summary>
        ChannelPost,

        /// <summary>
        /// The <see cref="Update"/> contains an edited channel post <see cref="Types.Message"/>
        /// </summary>
        EditedChannelPost,

        /// <summary>
        /// The <see cref="Update"/> contains an <see cref="ShippingQuery"/>
        /// </summary>
        ShippingQuery,

        /// <summary>
        /// The <see cref="Update"/> contains an <see cref="PreCheckoutQuery"/>
        /// </summary>
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
        public string Url { get; set; }

        /// <summary>
        /// True, если для проверки сертификатов webhook был предоставлен специальный сертификат
        /// </summary>
        [Required]
        public bool HasCustomCertificate { get; set; }

        /// <summary>
        /// Количество обновлений, ожидающих доставки
        /// </summary>
        [Required]
        public int PendingUpdateCount { get; set; }

        /// <summary>
        /// Необязательный. <see href="https://en.wikipedia.org/wiki/Unix_time">Unix временя</see> последней ошибки,
        /// которая произошла при попытке доставить обновление через webhook
        /// </summary>
        public DateTime LastErrorDate { get; set; }

        /// <summary>
        /// Необязательный. Сообщение об ошибке в удобочитаемом формате для последней ошибки,
        /// которая произошла при попытке доставить обновление через webhook
        /// </summary>
        public string LastErrorMessage { get; set; }

        /// <summary>
        /// Необязательный. Максимально допустимое количество одновременных HTTPS-подключений к webhook 
        /// для доставки обновлений
        /// </summary>
        public int MaxConnections { get; set; }

        /// <summary>
        /// Необязательный. Список типов обновлений, на которые подписан бот.
        /// </summary>
        /// <remarks>
        /// По умолчанию для всех типов обновлений
        /// </remarks>
        public UpdateType[] AllowedUpdates { get; set; }
    }
}
