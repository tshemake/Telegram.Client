using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Models
{
    /// <summary>
    /// Представляет проблему селфи с документом.
    /// <see href="https://core.telegram.org/bots/api#passportelementerrorselfie"/>
    /// </summary>
    /// <remarks>
    /// Ошибка считается исправленной при изменении файла с селфи.
    /// </remarks>
    public class PassportElementErrorSelfie
    {
        /// <summary>
        /// Источник ошибки, должен быть «selfie»
        /// </summary>
        [Required]
        public string Source { get; set; }

        /// <summary>
        /// Раздел паспорта пользователя Telegram, в котором есть проблема.
        /// Один из “passport”, “driver_license”, “identity_card”, “internal_passport”.
        /// </summary>
        [Required]
        public string Type { get; set; }

        /// <summary>
        /// Base64 закодированный хеш файла с селфи
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
