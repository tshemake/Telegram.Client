using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Types
{
    /// <summary>
    /// Телефонный контакт.
    /// <see href="https://core.telegram.org/bots/api#contact"/>
    /// </summary>
    public class Contact
    {
        [Key]
        public long Id { get; set; }

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
        /// Необязательный. Идентификатор пользователя контакта в Telegram
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Необязательный. Дополнительные данные о контакте в виде <see href="https://en.wikipedia.org/wiki/VCard">vCard</see>
        /// Размером до 2048 байт
        /// </summary>
        [MaxLength(2048)]
        public string VCard { get; set; }
    }
}
