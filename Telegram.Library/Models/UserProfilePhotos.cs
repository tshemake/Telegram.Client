using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Models
{
    /// <summary>
    /// Фотографии профиля пользователя.
    /// <see href="https://core.telegram.org/bots/api#userprofilephotos"/>
    /// </summary>
    public class UserProfilePhotos
    {
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Общее количество фотографий профиля у целевого пользователя
        /// </summary>
        [Required]
        public int TotalCount { get; set; }

        /// <summary>
        /// Запрошенные фотографии профиля (до 4 размеров каждая)
        /// </summary>
        [Required]
        public PhotoSize[][] Photos { get; set; }
    }
}
