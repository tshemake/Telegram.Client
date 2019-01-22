using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;

namespace Telegram.Library.Types
{
    /// <summary>
    /// Этот объект представляет входящий встроенный запрос.
    /// <see href="https://core.telegram.org/bots/api#inlinequery"/>
    /// </summary>
    /// <remarks>
    /// Когда пользователь отправляет пустой запрос, ваш бот может вернуть
    /// некоторые результаты по умолчанию или трендовые результаты.
    /// </remarks>
    public class InlineQuery
    {
        [Key]
        [JsonIgnore]
        public long Id { get; set; }

        /// <summary>
        /// Уникальный идентификатор для этого запроса
        /// </summary>
        [Required]
        [JsonProperty("id", Required = Required.Always)]
        public string UniqueIdQuery { get; set; }

        /// <summary>
        /// Отправитель
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public User From { get; set; }

        /// <summary>
        /// Необязательный. Местоположение отправителя
        /// </summary>
        /// <remarks>
        /// Только для ботов, которые запрашивают местоположение пользователя
        /// </remarks>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Location Location { get; set; }

        /// <summary>
        /// Текст запроса (до 512 символов)
        /// </summary>
        [Required]
        [MaxLength(512)]
        [JsonProperty(Required = Required.Always)]
        public string Query { get; set; }

        /// <summary>
        /// Смещение результатов, которые должны быть возвращены, может контролироваться ботом
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public string Offset { get; set; }
    }
}
