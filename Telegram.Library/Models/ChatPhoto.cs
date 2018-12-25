using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Models
{
    /// <summary>
    /// Фотография чата.
    /// <see href="https://core.telegram.org/bots/api#chatphoto"/>
    /// </summary>
    public class ChatPhoto
    {
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Уникальный идентификатор файла небольшой (160x160) фотографии чата.
        /// Этот идентификатор может быть использован только для загрузки фото.
        /// </summary>
        [Required]
        public string SmallFileId { get; set; }

        /// <summary>
        /// Уникальный идентификатор файла большой (640x640) фотографии чата. 
        /// Этот идентификатор может быть использован только для загрузки фото.
        /// </summary>
        [Required]
        public string BigFileId { get; set; }
    }
}
