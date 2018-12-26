using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Models
{
    /// <summary>
    /// <see href="https://core.telegram.org/bots/api#inputmessagecontent">Содержимое</see> сообщения о местоположении, 
    /// которое будет отправлено в результате встроенного запроса.
    /// <see href="https://core.telegram.org/bots/api#inputlocationmessagecontent"/>
    /// </summary>
    public class InputLocationMessageContent : InputMessageContent
    {
        /// <summary>
        /// Широта местоположения в градусах
        /// </summary>
        [Required]
        public float Latitude { get; private set; }

        /// <summary>
        /// Долгота местоположения в градусах
        /// </summary>
        [Required]
        public float Longitude { get; private set; }

        /// <summary>
        /// Необязательный. Период в секундах, за который местоположение может быть обновлено.
        /// </summary>
        /// <remarks>
        /// Должен быть от 60 до 86400.
        /// </remarks>
        public int LivePeriod { get; set; }
    }
}
