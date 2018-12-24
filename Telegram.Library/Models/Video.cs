using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Models
{
    /// <summary>
    /// This object represents a video file.
    /// <see href="https://core.telegram.org/bots/api#video"/>
    /// </summary>
    public class Video
    {
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Уникальный идентификатор этого файла
        /// </summary>
        [Required]
        public string UniqueFileId { get; set; }

        /// <summary>
        /// Ширина видео, определенное отправителем
        /// </summary>
        [Required]
        public int Width { get; set; }

        /// <summary>
        /// Высота видео, определенное отправителем
        /// </summary>
        [Required]
        public int Height { get; set; }

        /// <summary>
        /// Продолжительность видео в секундах, определенное отправителем
        /// </summary>
        [Required]
        public int Duration { get; set; }

        /// <summary>
        /// Необязательный. Миниатюра видео
        /// </summary>
        public PhotoSize Thumb { get; set; }

        /// <summary>
        /// Необязательный. Тип MIME файла, как определено отправителем
        /// </summary>
        public string MimeType { get; set; }

        /// <summary>
        /// Необязательный. Размер файла
        /// </summary>
        public int FileSize { get; set; }
    }
}
