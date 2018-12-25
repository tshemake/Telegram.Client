using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Models
{
    /// <summary>
    /// Представляет проблему в неопределенном месте.
    /// <see href="https://core.telegram.org/bots/api#passportelementerrorunspecified"/>
    /// </summary>
    /// <remarks>
    /// Ошибка считается устраненной при добавлении новых данных.
    /// </remarks>
    public class PassportElementErrorUnspecified
    {
        /// <summary>
        /// Источник ошибки, должен быть не указан
        /// </summary>
        [Required]
        public string Source { get; set; }

        /// <summary>
        /// Тип элемента Telegram Passport пользователя, который имеет проблему
        /// </summary>
        [Required]
        public string Type { get; set; }

        /// <summary>
        /// Base64-кодированный элемент хеша
        /// </summary>
        [Required]
        public string ElementHash { get; set; }

        /// <summary>
        /// Текст ошибки
        /// </summary>
        [Required]
        public string Message { get; set; }
    }
}
