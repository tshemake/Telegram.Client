using System;
using System.Collections.Generic;
using System.Text;

namespace Telegram.Library.Models
{
    /// <summary>
    /// Содержит информацию о том, почему запрос был неудачным.
    /// <see href="https://core.telegram.org/bots/api#responseparameters"/>
    /// </summary>
    public class ResponseParameters
    {
        /// <summary>
        /// Необязательный. «group» была перенесена в «supergroup» с указанным идентификатором.
        /// </summary>
        /// <remarks>
        /// Это число может быть больше 32 бит, но он меньше 52 бит.
        /// </remarks>
        public long MigrateToChatId { get; set; }

        /// <summary>
        /// Необязательный. В случае спама, количество секунд, оставшихся до возможной отправки запроса.
        /// </summary>
        /// <remarks>
        /// Может быть повторено
        /// </remarks>
        public int RetryAfter { get; set; }
    }
}
