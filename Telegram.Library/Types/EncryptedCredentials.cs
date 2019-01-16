using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Types
{
    /// <summary>
    /// Содержит данные, необходимые для расшифровки и аутентификации <see cref="EncryptedPassportElement"/>.
    /// См. <see href="https://core.telegram.org/passport#receiving-information">Telegram Passport
    /// Documentation</see> для полного описания процессов дешифрования и аутентификации данных.
    /// <see href="https://core.telegram.org/bots/api#encryptedcredentials"/>
    /// </summary>
    public class EncryptedCredentials
    {
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Зашифрованные в кодировке Base64 JSON-сериализованные данные с уникальной полезной нагрузкой пользователя, 
        /// хэшами и секретами данных, необходимыми для расшифровки и аутентификации <see cref="EncryptedPassportElement"/>.
        /// </summary>
        [Required]
        public string Data { get; set; }

        /// <summary>
        /// Base64-закодированный хэш данных для аутентификации данных
        /// </summary>
        [Required]
        public string Hash { get; set; }

        /// <summary>
        /// Секрет в кодировке Base64, зашифрованный открытым ключом RSA бота, необходимый для расшифровки данных
        /// </summary>
        [Required]
        public string Secret { get; set; }
    }
}
