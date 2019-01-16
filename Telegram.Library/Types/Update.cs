using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

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
        public long Id { get; set; }

        /// <summary>
        /// Уникальный идентификатор сообщения.
        /// Идентификаторы начинаются с определенного положительного числа и последовательно увеличиваются.
        /// </summary>
        /// <remarks>
        /// Игнорировать повторяющиеся обновления или восстанавливать правильную последовательность, если была ошибка.
        /// </remarks>
        [Required]
        public long UniqueUpdateId { get; set; }

        /// <summary>
        /// Необязательный. Новое входящее сообщение любого типа - текст, фотография, стикер и т.д.
        /// </summary>
        public Message Message { get; set; }

        /// <summary>
        /// Необязательный. Новая версия сообщения, которое известно боту и отредактировано
        /// </summary>
        public Message EditedMessage { get; set; }

        /// <summary>
        /// Необязательный. Новый входящий встроенный запрос
        /// </summary>
        public InlineQuery InlineQuery { get; set; }

        /// <summary>
        /// Необязательный. Результат встроенного запроса, который был выбран пользователем и отправлен его партнеру по чату
        /// </summary>
        public ChosenInlineResult ChosenInlineResult { get; set; }

        /// <summary>
        /// Необязательный.Новый входящий запрос обратного вызова
        /// </summary>
        public CallbackQuery CallbackQuery { get; set; }

        /// <summary>
        /// Необязательный. Новая входящая запись на канале любого типа - текст, фото, стикер и т.д.
        /// </summary>
        public Message ChannelPost { get; set; }

        /// <summary>
        /// Необязательный. Новая версия сообщения на «channel», известная боту и отредактированная
        /// </summary>
        public Message EditedChannelPost { get; set; }

        /// <summary>
        /// Необязательный. Новый запрос на входящую доставку. Только для счетов с гибкой ценой
        /// </summary>
        public ShippingQuery ShippingQuery { get; set; }

        /// <summary>
        /// Необязательный. Новый входящий запрос предварительной проверки.
        /// Содержит полную информацию об оформлении заказа
        /// </summary>
        public PreCheckoutQuery PreCheckoutQuery { get; set; }
    }
}
