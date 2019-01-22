using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;

namespace Telegram.Library.Types
{
    /// <summary>
    /// Фотографии профиля пользователя.
    /// <see href="https://core.telegram.org/bots/api#userprofilephotos"/>
    /// </summary>
    public class UserProfilePhotos
    {
        [Key]
        [JsonIgnore]
        public long Id { get; set; }

        /// <summary>
        /// Общее количество фотографий профиля у целевого пользователя
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public int TotalCount { get; set; }

        /// <summary>
        /// Запрошенные фотографии профиля (до 4 размеров каждая)
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public PhotoSize[][] Photos { get; set; }
    }
}
