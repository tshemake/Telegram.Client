using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Models
{
    /// <summary>
    /// Представляет проблему со сканированием документа.
    /// <see href="https://core.telegram.org/bots/api#passportelementerrorfile"/>
    /// </summary>
    /// <remarks>
    /// Ошибка считается устраненной при изменении файла со сканом документа.
    /// </remarks>
    public class PassportElementErrorFile
    {
        /// <summary>
        /// Источник ошибки, должен быть «file»
        /// </summary>
        [Required]
        public string Source { get; set; }

        /// <summary>
        /// Раздел паспорта пользователя Telegram, в котором есть проблема.
        /// Один из “utility_bill”, “bank_statement”, “rental_agreement”, “passport_registration”,
        /// “temporary_registration”.
        /// </summary>
        [Required]
        public string Type { get; set; }

        /// <summary>
        /// Base64 закодированный хеш файла
        /// </summary>
        [Required]
        public string FileHash { get; set; }

        /// <summary>
        /// Текст ошибки
        /// </summary>
        [Required]
        public string Message { get; set; }
    }
}
