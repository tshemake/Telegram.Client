using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Models
{
    /// <summary>
    /// Ссылка на стикер, хранящийся на серверах Telegram.
    /// <see href="https://core.telegram.org/bots/api#inlinequeryresultcachedsticker"/>
    /// </summary>
    /// <remarks>
    /// По умолчанию эта наклейка будет отправлена пользователем.
    /// Кроме того, вы можете использовать <see cref="InputMessageContent"/> для отправки сообщения с указанным содержимым вместо стикера.
    /// </remarks>
    public class InlineQueryResultCachedSticker
    {
        /// <summary>
        /// Тип результата, должен быть «sticker»
        /// </summary>
        [Required]
        public string Type { get; set; }

        /// <summary>
        /// Уникальный идентификатор для этого результата.
        /// </summary>
        /// <remarks>
        /// От 1 до 64 байта
        /// </remarks>
        [Required]
        public string UniqueCachedStickerId { get; set; }

        /// <summary>
        /// Действительный идентификатор файла стикера
        /// </summary>
        [Required]
        public string StickerFileId { get; set; }

        /// <summary>
        /// Необязательный. <see href="https://core.telegram.org/bots#inline-keyboards-and-on-the-fly-updating">Встроенная клавиатура</see> прикрепленая к сообщению
        /// </summary>
        public InlineKeyboardMarkup ReplyMarkup { get; set; }

        /// <summary>
        /// Необязательный. Содержание сообщения, которое будет отправлено вместо стикера
        /// </summary>
        public InputMessageContent InputMessageContent { get; set; }
    }
}
