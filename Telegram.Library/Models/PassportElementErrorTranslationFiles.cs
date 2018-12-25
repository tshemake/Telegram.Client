using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Models
{
    /// <summary>
    /// Представляет проблему с переведенной версией документа.
    /// <see href="https://core.telegram.org/bots/api#passportelementerrortranslationfiles"/>
    /// </summary>
    /// <remarks>
    /// Ошибка считается исправленной, когда файл с переводом документа изменяется.
    /// </remarks>
    public class PassportElementErrorTranslationFiles
    {
        /// <summary>
        /// Источник ошибки, должен быть «translation_files»
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
        /// Список Base64 хешей файлов
        /// </summary>
        [Required]
        public IEnumerable<string> FileHashes { get; set; }

        /// <summary>
        /// Текст ошибки
        /// </summary>
        [Required]
        public string Message { get; set; }
    }
}
