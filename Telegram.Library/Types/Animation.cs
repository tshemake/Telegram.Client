using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Types
{
    /// <summary>
    /// Файл анимации (в формате GIF или видео <see href="https://en.wikipedia.org/wiki/H.264/MPEG-4_AVC">H.264/MPEG-4 AVC</see> без звука).
    /// <see href="https://core.telegram.org/bots/api#animal"/>
    /// </summary>
    public class Animation
    {
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Уникальный идентификатор файла
        /// </summary>
        [Required]
        public string FileId { get; set; }

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
        /// Необязательный. Миниатюра анимации, определенное отправителем
        /// </summary>
        public PhotoSize Thumb { get; set; }

        /// <summary>
        /// Необязательный. Исходное имя файла анимации, определенное отправителем
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Необязательный. MIME-тип файла, определенный отправителем
        /// </summary>
        public string MimeType { get; set; }

        /// <summary>
        /// File size.
        /// </summary>
        public int FileSize { get; set; }
    }
}
