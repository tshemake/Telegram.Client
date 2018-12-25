using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Models
{
    /// <summary>
    /// <see href="https://core.telegram.org/bots/api#inputmessagecontent">Содержимое</see> сообщения места, которое будет отправлено 
    /// в результате встроенного запроса.
    /// </summary>
    class InputVenueMessageContent
    {
        /// <summary>
        /// Широта места встречи в градусах
        /// </summary>
        [Required]
        public float Latitude { get; private set; }

        /// <summary>
        /// Долгота места встречи в градусах
        /// </summary>
        [Required]
        public float Longitude { get; private set; }

        /// <summary>
        /// Название места встречи
        /// </summary>
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// Адрес места проведения
        /// </summary>
        [Required]
        public string Address { get; private set; }

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
    }
}
