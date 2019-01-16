using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Types
{
    /// <summary>
    /// Представляет проблему со списком сканов.
    /// <see href="https://core.telegram.org/bots/api#passportelementerrorfiles"/>
    /// </summary>
    /// <remarks>
    /// Ошибка считается устраненной при изменении списка файлов, содержащих сканы.
    /// </remarks>
    public class PassportElementErrorFiles
    {
        /// <summary>
        /// Источник ошибки, должен быть «files»
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
