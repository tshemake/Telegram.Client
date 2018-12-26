using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Models
{
    /// <summary>
    /// Местоположение на карте.
    /// <see href="https://core.telegram.org/bots/api#inlinequeryresultlocation"/>
    /// </summary>
    /// <remarks>
    /// По умолчанию местоположение будет отправлено пользователем.
    /// В качестве альтернативы вы можете использовать <see cref="InputMessageContent"/> 
    /// для отправки сообщения с указанным содержимым вместо местоположения.
    /// В настоящее время с помощью этого метода можно отправлять только .PDF и .ZIP файлы.
    /// Это будет работать только в Telegram версиях, выпущенных после 9 апреля 2016 года.
    /// Старые клиенты их игнорируют.
    /// </remarks>
    public class InlineQueryResultLocation
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
        /// Широта местоположения в градусах
        /// </summary>
        [Required]
        public float Latitude { get; set; }

        /// <summary>
        /// Долгота местоположения в градусах
        /// </summary>
        [Required]
        public float Longitude { get; set; }

        /// <summary>
        /// Название места
        /// </summary>
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// Необязательный. Период в секундах, за который местоположение может быть обновлено.
        /// </summary>
        /// <remarks>
        /// Должен быть от 60 до 86400.
        /// </remarks>
        public int LivePeriod { get; set; }

        /// <summary>
        /// Необязательный. <see href="https://core.telegram.org/bots#inline-keyboards-and-on-the-fly-updating">Встроенная клавиатура</see> прикрепленая к сообщению
        /// </summary>
        public InlineKeyboardMarkup ReplyMarkup { get; set; }

        /// <summary>
        /// Необязательный. Содержимое сообщения, которое будет отправлено вместо местоположения
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
