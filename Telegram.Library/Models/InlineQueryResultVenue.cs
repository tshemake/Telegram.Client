using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Models
{
    /// <summary>
    /// Место проведения.
    /// <see href="https://core.telegram.org/bots/api#inlinequeryresultvenue"/>
    /// </summary>
    /// <remarks>
    /// По умолчанию место будет отправлено пользователем.
    /// В качестве альтернативы вы можете использовать <see cref="InputMessageContent"/> 
    /// для отправки сообщения с указанным содержимым вместо места проведения.
    /// В настоящее время с помощью этого метода можно отправлять только .PDF и .ZIP файлы.
    /// Это будет работать только в Telegram версиях, выпущенных после 9 апреля 2016 года.
    /// Старые клиенты их игнорируют.
    /// </remarks>
    public class InlineQueryResultVenue
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
        /// Широта координаты места проведения в градусах
        /// </summary>
        [Required]
        public float Latitude { get; set; }

        /// <summary>
        /// Необязательный. Идентификатор «foursquare» места проведения
        /// </summary>
        public string FoursquareId { get; set; }

        /// <summary>
        /// Необязательный. Тип «foursquare».
        /// </summary>
        /// <example>
        /// «arts_entertainment/default», «arts_entertainment/aquarium» или «food/icecream»
        /// </example>
        public string FoursquareType { get; set; }

        /// <summary>
        /// Необязательный. <see href="https://core.telegram.org/bots#inline-keyboards-and-on-the-fly-updating">Встроенная клавиатура</see> прикрепленая к сообщению
        /// </summary>
        public InlineKeyboardMarkup ReplyMarkup { get; set; }

        /// <summary>
        /// Необязательный. Содержимое сообщения, которое будет отправлено вместо места проведения
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
