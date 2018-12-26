using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Models
{
    /// <summary>
    /// Ссылка на страницу, содержащий встроенный видеоплеер или видеофайл.
    /// <see href="https://core.telegram.org/bots/api#inlinequeryresultvideo"/>
    /// </summary>
    /// <remarks>
    /// По умолчанию этот видеофайл будет отправлен пользователем с необязательной подписью.
    /// В качестве альтернативы вы можете использовать <see cref="InputMessageContent"/> для отправки сообщения с указанным содержимым вместо видео.
    /// </remarks>
    public class InlineQueryResultVideo
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
        /// Действительный URL адрес для встроенного видеоплеера или видеофайл
        /// </summary>
        [Required]
        public string VideoUrl { get; set; }

        /// <summary>
        /// MIME-тип содержимого видео URL, «text/html» или «video/mp4»
        /// </summary>
        [Required]
        public string MimeType { get; set; }

        /// <summary>
        /// URL адрес миниатюры (только в формате JPEG) для видео
        /// </summary>
        [Required]
        public string ThumbUrl { get; set; }

        /// <summary>
        /// Необязательный. Название для результата
        /// </summary>
        [Required]
        public string Title { get; set; }

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
        /// Необязательный. Ширина видео
        /// </summary>
        public int VideoWidth { get; set; }

        /// <summary>
        /// Необязательный. Высота видео
        /// </summary>
        public int VideoHeight { get; set; }

        /// <summary>
        /// Необязательный. Продолжительность видео
        /// </summary>
        public int VideoDuration { get; set; }

        /// <summary>
        /// Необязательный. Краткое описание результата
        /// </summary>
        public string Description { get; set; }

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
