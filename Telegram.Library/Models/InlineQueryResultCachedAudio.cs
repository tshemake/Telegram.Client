using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Models
{
    /// <summary>
    /// Ссылка на аудиофайл в формате mp3, хранящийся на серверах Telegram.
    /// <see href="https://core.telegram.org/bots/api#inlinequeryresultaudio"/>
    /// </summary>
    /// <remarks>
    /// По умолчанию этот аудиофайл будет отправлен пользователем.
    /// В качестве альтернативы вы можете использовать <see cref="InputMessageContent"/> 
    /// для отправки сообщения с указанным контентом вместо аудио.
    /// Это будет работать только в Telegram версиях, выпущенных после 9 апреля 2016 года.
    /// Старые клиенты их игнорируют.
    /// </remarks>
    public class InlineQueryResultCachedAudio
    {
        /// <summary>
        /// Тип результата, должен быть «audio»
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
        /// Допустимый идентификатор файла для аудиофайла
        /// </summary>
        [Required]
        public string AudioFileId { get; set; }

        /// <summary>
        /// Необязательный. Заголовок, длиной до 1024 символов
        /// </summary>
        [MaxLength(1024)]
        public string Caption { get; set; }

        /// <summary>
        /// Необязательный. <see href="https://core.telegram.org/bots#inline-keyboards-and-on-the-fly-updating">Встроенная клавиатура</see> прикрепленая к сообщению
        /// </summary>
        public InlineKeyboardMarkup ReplyMarkup { get; set; }

        /// <summary>
        /// Необязательный. Содержимое сообщения, которое будет отправлено вместо аудио
        /// </summary>
        public InputMessageContent InputMessageContent { get; set; }
    }
}
