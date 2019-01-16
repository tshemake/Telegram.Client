using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Types
{
    /// <summary>
    /// Ссылка на файл, хранящийся на серверах Telegram.
    /// <see href="https://core.telegram.org/bots/api#inlinequeryresultcacheddocument"/>
    /// </summary>
    /// <remarks>
    /// По умолчанию этот файл отправляется пользователем с необязательной подписью.
    /// В качестве альтернативы вы можете использовать <see cref="InputMessageContent"/> 
    /// для отправки сообщения с указанным содержимым вместо файла.
    /// В настоящее время с помощью этого метода можно отправлять только .PDF и .ZIP файлы.
    /// Это будет работать только в Telegram версиях, выпущенных после 9 апреля 2016 года.
    /// Старые клиенты их игнорируют.
    /// </remarks>
    public class InlineQueryResultCachedDocument
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
        /// Заголовок для результата
        /// </summary>
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// Действительный идентификатор файла для файла
        /// </summary>
        [Required]
        public string DocumentFileId { get; set; }

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
        /// Необязательный. <see href="https://core.telegram.org/bots#inline-keyboards-and-on-the-fly-updating">Встроенная клавиатура</see> прикрепленая к сообщению
        /// </summary>
        public InlineKeyboardMarkup ReplyMarkup { get; set; }

        /// <summary>
        /// Необязательный. Содержимое сообщения, которое будет отправлено вместо файла
        /// </summary>
        public InputMessageContent InputMessageContent { get; set; }
    }
}
