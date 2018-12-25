using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Models
{
    /// <summary>
    /// Представляет проблему с одним из файлов, составляющих перевод документа.
    /// <see href="https://core.telegram.org/bots/api#passportelementerrortranslationfile"/>
    /// </summary>
    /// <remarks>
    /// Ошибка считается устраненной при изменении файла.
    /// </remarks>
    public class PassportElementErrorTranslationFile
    {
        /// <summary>
        /// Источник ошибки, должен быть «translation_file»
        /// </summary>
        [Required]
        public string Source { get; set; }

        /// <summary>
        /// Тип элемента Telegram Passport пользователя. Один из “passport”, 
        /// “driver_license”, “identity_card”, “internal_passport”, “utility_bill”,
        /// “bank_statement”, “rental_agreement”, “passport_registration”, 
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
