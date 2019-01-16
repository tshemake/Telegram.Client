using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Types
{
    /// <summary>
    /// Ссылка на видеофайл, хранящийся на серверах Telegram.
    /// <see href="https://core.telegram.org/bots/api#inlinequeryresultvideo"/>
    /// </summary>
    /// <remarks>
    /// По умолчанию этот видеофайл будет отправлен пользователем с необязательной подписью.
    /// В качестве альтернативы вы можете использовать <see cref="InputMessageContent"/> для отправки сообщения с указанным содержимым вместо видео.
    /// </remarks>
    public class InlineQueryResultCachedVideo
    {
        /// <summary>
        /// Тип результата, должен быть «video»
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
        /// Действительный идентификатор файла для видеофайла
        /// </summary>
        [Required]
        public string VideoFileId { get; set; }

        /// <summary>
        /// Необязательный. Название для результата
        /// </summary>
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// Необязательный. Краткое описание результата
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Необязательный. Заголовок видео для отправки, длиной до 1024 символов
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
        /// Необязательный. Содержимое сообщения, которое будет отправлено вместо видео
        /// </summary>
        public InputMessageContent InputMessageContent { get; set; }
    }
}
