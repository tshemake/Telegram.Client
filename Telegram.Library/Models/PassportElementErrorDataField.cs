using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Models
{
    /// <summary>
    /// Представляет проблему в одном из полей данных, предоставленных пользователем.
    /// <see href="https://core.telegram.org/bots/api#passportelementerrordatafield"/>
    /// </summary>
    /// <remarks>
    /// Ошибка считается устраненной при изменении значения поля.
    /// </remarks>
    public class PassportElementErrorDataField
    {
        /// <summary>
        /// Источник ошибки, должен быть «data»
        /// </summary>
        [Required]
        public string Source { get; set; }

        /// <summary>
        /// Раздел паспорта пользователя Telegram, в котором есть ошибка.
        /// Один из “personal_details”, “passport”, “driver_license”, “identity_card”, 
        /// “internal_passport”, “address”.
        /// </summary>
        [Required]
        public string Type { get; set; }

        /// <summary>
        /// Имя поля данных, в котором есть ошибка
        /// </summary>
        [Required]
        public string FieldName { get; set; }

        /// <summary>
        /// Base64 закодированный хеш данных
        /// </summary>
        [Required]
        public string DataHash { get; set; }

        /// <summary>
        /// Текст ошибки
        /// </summary>
        [Required]
        public string Message { get; set; }
    }
}
