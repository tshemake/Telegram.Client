using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Models
{
    /// <summary>
    /// Ссылку на фотографию, хранящуюся на серверах Telegram.
    /// <see href="https://core.telegram.org/bots/api#inlinequeryresultcachedphoto"/>
    /// </summary>
    /// <remarks>
    /// По умолчанию эта фотография будет отправлена пользователем с необязательной подписью. 
    /// Кроме того, вы можете использовать <see cref="InputMessageContent"/> для отправки сообщения с указанным содержимым вместо фотографии.
    /// </remarks>
    public class InlineQueryResultCachedPhoto
    {
        /// <summary>
        /// Тип результата, должен быть «photo»
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
        public string UniqueId { get; set; }

        /// <summary>
        /// Действительный идентификатор файла фотографии
        /// </summary>
        [Required]
        public string PhotoFileId { get; set; }

        /// <summary>
        /// Необязательный. Название для результата
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Необязательный. Краткое описание результата
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Необязательный. Заголовок фотографии для отправки, длиной до 1024 символов
        /// </summary>
        [MaxLength(1024)]
        public string Caption { get; set; }

        /// <summary>
        /// Необязательный. Отправьте <see href="https://core.telegram.org/bots/api#markdown-style">Markdown</see> или <see href="https://core.telegram.org/bots/api#html-style">HTML</see>, если вы хотите 
        /// чтобы приложения Telegram отображали
        /// <see href="https://core.telegram.org/bots/api#formatting-options">жирный шрифт, курсив, текст фиксированной ширины или встроенные URL-адреса</see> в заголовке мультимедиа.
        /// </summary>
        public ParseMode ParseMode { get; set; }

        /// <summary>
        /// Необязательный. <see href="https://core.telegram.org/bots#inline-keyboards-and-on-the-fly-updating">Встроенная клавиатура</see> прикрепленая к сообщению
        /// </summary>
        public InlineKeyboardMarkup ReplyMarkup { get; set; }

        /// <summary>
        /// Необязательный. Содержание сообщения, которое будет отправлено вместо фотографии
        /// </summary>
        public InputMessageContent InputMessageContent { get; set; }
    }
}
