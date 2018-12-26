using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Models
{
    /// <summary>
    /// <see href="https://core.telegram.org/bots/api#inputmessagecontent">Содержимое</see> контактного сообщения, которое будет отправлено в результате встроенного запроса.
    /// <see href="https://core.telegram.org/bots/api#inputcontactmessagecontent"/>
    /// </summary>
    public class InputContactMessageContent : InputMessageContent
    {
        /// <summary>
        /// Контактный телефон
        /// </summary>
        [Required]
        public string PhoneNumber { get; private set; }

        /// <summary>
        /// Имя контакта
        /// </summary>
        [Required]
        public string FirstName { get; private set; }

        /// <summary>
        /// Необязательный. Фамилия контакта
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Необязательный. Дополнительные данные о контакте в виде <see href="https://en.wikipedia.org/wiki/VCard">vCard</see>.
        /// Размером до 2048 байт
        /// </summary>
        public string VCard { get; set; }
    }
}
