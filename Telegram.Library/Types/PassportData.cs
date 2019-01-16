using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Types
{
    /// <summary>
    /// Данные Telegram Passport, которыми пользователь делится с ботом.
    /// <see href="https://core.telegram.org/bots/api#passportdata"/>
    /// </summary>
    public class PassportData
    {
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Массив с информацией о документах и других элементах Telegram Passport, которые были переданы боту
        /// </summary>
        [Required]
        public ICollection<EncryptedPassportElement> Data { get; set; }

        /// <summary>
        /// Зашифрованные учетные данные, необходимые для расшифровки данных
        /// </summary>
        [Required]
        public EncryptedCredentials Credentials { get; set; }
    }
}
