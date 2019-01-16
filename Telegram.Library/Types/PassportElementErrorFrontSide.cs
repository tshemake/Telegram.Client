using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Types
{
    /// <summary>
    /// Представляет проблему с лицевой стороной документа.
    /// <see href="https://core.telegram.org/bots/api#passportelementerrorfrontside"/>
    /// </summary>
    /// <remarks>
    /// Ошибка считается устраненной, когда файл с лицевой стороной документа изменяется.
    /// </remarks>
    public class PassportElementErrorFrontSide
    {
        /// <summary>
        /// Источник ошибки, должен быть «front_side»
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
        /// Base64 закодированный хеш файла с лицевой стороной документа
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
