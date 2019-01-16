using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.Library.Types
{
    /// <summary>
    /// Пользовател Telegram'ма или бот.
    /// <see href="https://core.telegram.org/bots/api#user"/>
    /// </summary>
    [JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class User
    {
        [Key]
        [JsonIgnore]
        public long Id { get; set; }

        /// <summary>
        /// Уникальный идентификатор для пользователя или бота
        /// </summary>
        [Required]
        [JsonProperty(PropertyName = "id", Required = Required.Always)]
        public long UniqueUserId { get; set; }

        /// <summary>
        /// Этот пользователь бот?
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public bool IsBot { get; set; }

        /// <summary>
        /// FirstName пользователя или бота
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public string FirstName { get; set; }

        /// <summary>
        /// Необязательный. LastName пользователя или бота
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LastName { get; set; }

        /// <summary>
        /// Необязательный. Username пользователя или бота
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Username { get; set; }

        /// <summary>
        /// Необязательный. <see href="https://en.wikipedia.org/wiki/IETF_language_tag">IETF</see> тег языка пользователя
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LanguageCode { get; set; }
    }
}
