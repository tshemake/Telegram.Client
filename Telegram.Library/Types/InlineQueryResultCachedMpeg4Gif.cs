using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Types
{
    /// <summary>
    /// Ссылка на видео анимацию (<see href="https://en.wikipedia.org/wiki/H.264/MPEG-4_AVC">H.264/MPEG-4 AVC</see> видео без звука) хранящийся на серверах Telegram.
    /// <see href="https://core.telegram.org/bots/api#inlinequeryresultcachedmpeg4gif"/>
    /// </summary>
    /// <remarks>
    /// По умолчанию этот анимированный MPEG-4 файл будет отправлен пользователем с необязательной подписью
    /// Кроме того, вы можете использовать <see cref="InputMessageContent"/> для отправки сообщения с указанным содержимым вместо анимации.
    /// </remarks>
    public class InlineQueryResultCachedMpeg4Gif
    {
        /// <summary>
        /// Тип результата, должен быть «mpeg4_gif»
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
        /// Допустимый идентификатор файла для MP4 файла
        /// </summary>
        [Required]
        public string Mpeg4FileId { get; set; }

        /// <summary>
        /// Необязательный. Название для результата
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Необязательный. Заголовок MPEG-4 файла для отправки, длиной до 1024 символов
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
        /// Необязательный. Содержимое сообщения, которое будет отправлено вместо видео анимации
        /// </summary>
        public InputMessageContent InputMessageContent { get; set; }
    }
}
