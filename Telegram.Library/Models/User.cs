using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Models
{
    /// <summary>
    /// Пользовател Telegram'ма или бот.
    /// <see href="https://core.telegram.org/bots/api#user"/>
    /// </summary>
    public class User
    {
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Уникальный идентификатор для пользователя или бота
        /// </summary>
        [Required]
        public long UniqueUserId { get; set; }

        /// <summary>
        /// Этот пользователь бот?
        /// </summary>
        [Required]
        public bool IsBot { get; set; }

        /// <summary>
        /// FirstName пользователя или бота
        /// </summary>
        [Required]
        public string FirstName { get; set; }

        /// <summary>
        /// Необязательный. LastName пользователя или бота
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Необязательный. Username пользователя или бота
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Необязательный. <see href="https://en.wikipedia.org/wiki/IETF_language_tag">IETF</see> тег языка пользователя
        /// </summary>
        public string LanguageCode { get; set; }
    }
}
