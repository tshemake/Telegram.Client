using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Types
{
    /// <summary>
    /// Ссылка на видео анимацию (<see href="https://en.wikipedia.org/wiki/H.264/MPEG-4_AVC">H.264/MPEG-4 AVC</see> видео без звука).
    /// <see href="https://core.telegram.org/bots/api#inlinequeryresultmpeg4gif"/>
    /// </summary>
    /// <remarks>
    /// По умолчанию этот анимированный MPEG-4 файл будет отправлен пользователем с необязательной подписью
    /// Кроме того, вы можете использовать <see cref="InputMessageContent"/> для отправки сообщения с указанным содержимым вместо анимации.
    /// </remarks>
    public class InlineQueryResultMpeg4Gif
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
        /// Действительный URL-адрес для MP4 файла
        /// </summary>
        /// <remarks>
        /// Размер файла не должен превышать 1 МБ
        /// </remarks>
        [Required]
        public string Mpeg4Url { get; set; }

        /// <summary>
        /// Необязательный. Ширина видео
        /// </summary>
        public int Mpeg4Width { get; set; }

        /// <summary>
        /// Необязательный. Высота видео
        /// </summary>
        public int Mpeg4Height { get; set; }

        /// <summary>
        /// Необязательный. Продолжительность видео
        /// </summary>
        public int Mpeg4Duration { get; set; }

        /// <summary>
        /// URL статического миниатюры для результата (jpeg или gif)
        /// </summary>
        [Required]
        public string ThumbUrl { get; set; }

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
