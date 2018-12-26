using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Models
{
    /// <summary>
    /// Ссылка на файл.
    /// <see href="https://core.telegram.org/bots/api#inlinequeryresultdocument"/>
    /// </summary>
    /// <remarks>
    /// По умолчанию этот файл отправляется пользователем с необязательной подписью.
    /// В качестве альтернативы вы можете использовать <see cref="InputMessageContent"/> 
    /// для отправки сообщения с указанным содержимым вместо файла.
    /// В настоящее время с помощью этого метода можно отправлять только .PDF и .ZIP файлы.
    /// Это будет работать только в Telegram версиях, выпущенных после 9 апреля 2016 года.
    /// Старые клиенты их игнорируют.
    /// </remarks>
    public class InlineQueryResultDocument
    {
        /// <summary>
        /// Тип результата, должен быть «document»
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
        /// Заголовок для результата
        /// </summary>
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// Необязательный. Заголовок документа для отправки, длиной до 1024 символов
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
        /// Действительный URL для файла
        /// </summary>
        [Required]
        public string DocumentUrl { get; set; }

        /// <summary>
        /// MIME-тип содержимого файла: «application/pdf» или «application/zip»
        /// </summary>
        [Required]
        public string MimeType { get; set; }

        /// <summary>
        /// Необязательный. Краткое описание результата
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Необязательный. <see href="https://core.telegram.org/bots#inline-keyboards-and-on-the-fly-updating">Встроенная клавиатура</see> прикрепленая к сообщению
        /// </summary>
        public InlineKeyboardMarkup ReplyMarkup { get; set; }

        /// <summary>
        /// Необязательный. Содержимое сообщения, которое будет отправлено вместо файла
        /// </summary>
        public InputMessageContent InputMessageContent { get; set; }

        /// <summary>
        /// Необязательный. URL адрес миниатюры (только в формате jpeg) для файла
        /// </summary>
        public string ThumbUrl { get; set; }

        /// <summary>
        /// Необязательный. Ширина миниатюры
        /// </summary>
        public int ThumbWidth { get; set; }

        /// <summary>
        /// Необязательный. Высота миниатюры
        /// </summary>
        public int ThumbHeight { get; set; }
    }
}
