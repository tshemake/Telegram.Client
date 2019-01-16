using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Types
{
    /// <summary>
    /// Контакт с номером телефона.
    /// <see href="https://core.telegram.org/bots/api#inlinequeryresultcontact"/>
    /// </summary>
    /// <remarks>
    /// По умолчанию этот контакт будет отправлен пользователем.
    /// В качестве альтернативы вы можете использовать <see cref="InputMessageContent"/> 
    /// для отправки сообщения с указанным содержимым вместо контакта.
    /// В настоящее время с помощью этого метода можно отправлять только .PDF и .ZIP файлы.
    /// Это будет работать только в Telegram версиях, выпущенных после 9 апреля 2016 года.
    /// Старые клиенты их игнорируют.
    /// </remarks>
    public class InlineQueryResultContact
    {
        /// <summary>
        /// Тип результата, должен быть «location»
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
        /// Контактный телефон
        /// </summary>
        [Required]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Имя контакта
        /// </summary>
        [Required]
        public string FirstName { get; set; }

        /// <summary>
        /// Необязательный. Фамилия контакта
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Необязательный. Дополнительные данные о контакте в виде <see href="https://en.wikipedia.org/wiki/VCard">vCard</see>
        /// Размером до 2048 байт
        /// </summary>
        [MaxLength(2048)]
        public string VCard { get; set; }

        /// <summary>
        /// Необязательный. <see href="https://core.telegram.org/bots#inline-keyboards-and-on-the-fly-updating">Встроенная клавиатура</see> прикрепленая к сообщению
        /// </summary>
        public InlineKeyboardMarkup ReplyMarkup { get; set; }

        /// <summary>
        /// Необязательный. Содержимое сообщения, которое будет отправлено вместо контакта
        /// </summary>
        public InputMessageContent InputMessageContent { get; set; }

        /// <summary>
        /// Необязательный. URL адрес миниатюры для результата
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
