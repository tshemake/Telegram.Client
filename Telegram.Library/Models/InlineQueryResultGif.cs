using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Models
{
    /// <summary>
    /// Ссылка на анимированный <see href="https://en.wikipedia.org/wiki/GIF">GIF-файл</see>. 
    /// <see href="https://core.telegram.org/bots/api#inlinequeryresultgif"/>
    /// </summary>
    /// <remarks>
    /// По умолчанию этот анимированный GIF-файл отправляется пользователем с необязательной подписью.
    /// Кроме того, вы можете использовать <see cref="InputMessageContent"/> для отправки сообщения с указанным содержимым вместо анимации.
    /// </remarks>
    public class InlineQueryResultGif
    {
        /// <summary>
        /// Тип результата, должен быть «gif»
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
        /// Действительный URL-адрес для GIF файла
        /// </summary>
        /// <remarks>
        /// Размер файла не должен превышать 1 МБ
        /// </remarks>
        [Required]
        public string GifUrl { get; set; }

        /// <summary>
        /// Необязательный. Ширина GIF файла
        /// </summary>
        public int GifWidth { get; set; }

        /// <summary>
        /// Необязательный. Высота GIF файла
        /// </summary>
        public int GifHeight { get; set; }

        /// <summary>
        /// Необязательный. Продолжительность GIF файла
        /// </summary>
        public int GifDuration { get; set; }

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
        /// Необязательный. Краткое описание результата
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Необязательный. Заголовок GIF файла для отправки, длиной до 1024 символов
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
        /// Необязательный. Содержимое сообщения, которое будет отправлено вместо GIF анимации
        /// </summary>
        public InputMessageContent InputMessageContent { get; set; }
    }
}
