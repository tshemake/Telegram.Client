using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Types
{
    /// <summary>
    /// Представляет проблему с обратной стороной документа.
    /// <see href="https://core.telegram.org/bots/api#passportelementerrorreverseside"/>
    /// </summary>
    /// <remarks>
    /// Ошибка считается устраненной, если файл с обратной стороной документа изменяется.
    /// </remarks>
    public class PassportElementErrorReverseSide
    {
        /// <summary>
        /// Источник ошибки, должен быть «reverse_side»
        /// </summary>
        [Required]
        public string Source { get; set; }

        /// <summary>
        /// Раздел паспорта пользователя Telegram, в котором есть проблема.
        /// Один из “driver_license”, “identity_card”.
        /// </summary>
        [Required]
        public string Type { get; set; }

        /// <summary>
        /// Base64 закодированный хеш файла с обратной стороной документа
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
