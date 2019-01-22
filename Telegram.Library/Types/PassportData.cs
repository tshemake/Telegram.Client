using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;

namespace Telegram.Library.Types
{
    /// <summary>
    /// Данные Telegram Passport, которыми пользователь делится с ботом.
    /// <see href="https://core.telegram.org/bots/api#passportdata"/>
    /// </summary>
    public class PassportData
    {
        [Key]
        [JsonIgnore]
        public long Id { get; set; }

        /// <summary>
        /// Массив с информацией о документах и других элементах Telegram Passport, которые были переданы боту
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public IEnumerable<EncryptedPassportElement> Data { get; set; }

        /// <summary>
        /// Зашифрованные учетные данные, необходимые для расшифровки данных
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public EncryptedCredentials Credentials { get; set; }
    }
}
