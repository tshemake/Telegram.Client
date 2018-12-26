using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Models
{
    /// <summary>
    /// Ссылку на запись голоса в контейнере <see cref="https://en.wikipedia.org/wiki/Ogg">.ogg</see>, закодированном с помощью <see href="https://opus-codec.org/">OPUS</see>.
    /// <see href="https://core.telegram.org/bots/api#inlinequeryresultvideo"/>
    /// </summary>
    /// <remarks>
    /// По умолчанию эта голосовая запись будет отправлена пользователем.
    /// В качестве альтернативы вы можете использовать <see cref="InputMessageContent"/> для отправки сообщения с указанным содержимым вместо голосового сообщения.
    /// Это будет работать только в Telegram версиях, выпущенных после 9 апреля 2016 года.
    /// Старые клиенты их игнорируют.
    /// </remarks>
    public class InlineQueryResultVoice
    {
        /// <summary>
        /// Тип результата, должен быть «voice»
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
        /// Действительный URL для записи голоса
        /// </summary>
        [Required]
        public string VoiceUrl { get; set; }

        /// <summary>
        /// Название для результата
        /// </summary>
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// Необязательный. Заголовок, длиной до 1024 символов
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
        /// Необязательный. Продолжительность записи в секундах
        /// </summary>
        public int VoiceDuration { get; set; }

        /// <summary>
        /// Необязательный. <see href="https://core.telegram.org/bots#inline-keyboards-and-on-the-fly-updating">Встроенная клавиатура</see> прикрепленая к сообщению
        /// </summary>
        public InlineKeyboardMarkup ReplyMarkup { get; set; }

        /// <summary>
        /// Необязательный. Содержимое сообщения, которое будет отправлено вместо записи голоса
        /// </summary>
        public InputMessageContent InputMessageContent { get; set; }
    }
}
